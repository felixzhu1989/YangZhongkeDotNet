using FileService.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace FileService.Infrastructure.Services
{
    /// <summary>
    /// 实现IStorageClient，将文件存储在FileService.WebAPI的wwwroot文件夹下
    /// </summary>
    public class MockCloudStorageClient:IStorageClient
    {
        /// <summary>
        /// 把FileService.WebAPI当成一个云存储服务器，是一个Mock。文件保存在wwwroot文件夹下。
        /// 这仅供开发、演示阶段使用，在生产环境中，一定要用专门的云存储服务器来代替。
        /// </summary>
        public StorageType StorageType => StorageType.Public;
        private readonly IWebHostEnvironment _hostEnv;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MockCloudStorageClient(IWebHostEnvironment hostEnv,IHttpContextAccessor httpContextAccessor)
        {
            _hostEnv = hostEnv;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Uri> SaveAsync(string key, Stream content, CancellationToken cancellationToken = default)
        {
            //要求key不以/开头
            if (key.StartsWith('/'))
            {
                throw new ArgumentException("Key should not start with /", nameof(key));
            }
            //获取当前web服务器的wwwroot路径
            string workingDir = Path.Combine(_hostEnv.ContentRootPath, "wwwroot");
            string fullPath = Path.Combine(workingDir, key);//key是DomainService中拼接了日期路径的文件名
            string? fullDir = Path.GetDirectoryName(fullPath);//get the directory，获取路径（剔除文件名） 
            //automatically create dir，如果不存在就创建这个路径
            if (!Directory.Exists(fullDir)) Directory.CreateDirectory(fullDir);
            //再判断文件是否存在，同名文件？尝试删除
            if(File.Exists(fullPath)) File.Delete(fullPath);
            await using Stream outStream = File.OpenWrite(fullPath);
            content.Position=0;//复位流读取的位置，因为上面已经读取过流了，为了下一次再读取流，应当复位流的指针
            await content.CopyToAsync(outStream, cancellationToken);//写入
            var req = _httpContextAccessor.HttpContext.Request;
            //string url = $"{req.Scheme}://{req.Host}/{key}";
            string url = $"{req.Scheme}://localhost/FileService/{key}";
            //因为是通过Nginx访问，因此组合出文件的路径
            return new Uri(url);
        }
    }
}
