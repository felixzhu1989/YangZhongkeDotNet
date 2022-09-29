using FileService.Domain;
using FileService.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Zack.ASPNETCore;

namespace FileService.WebAPI.Controllers
{
    //NuGet安装：Install-Package Zack.ASPNETCore
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]//权限
    [UnitOfWork(typeof(FSDbContext))]
    //todo:要做权限控制，这个接口即对内部系统开放、又对前端用户开放。
    public class UploaderController : ControllerBase
    {
        private readonly FSDomainService _domainService;
        private readonly FSDbContext _dbContext;
        private readonly IFSRepository _repository;

        public UploaderController(FSDomainService domainService,FSDbContext dbContext,IFSRepository repository)
        {
            _domainService = domainService;
            _dbContext = dbContext;
            _repository = repository;
        }

        [HttpGet("FileExists")]
        public async Task<FileExistsResponse> FileExists(long fileSize, string sha256Hash)
        {
            var item = await _repository.FindFileAsync(fileSize, sha256Hash);
            if (item == null) return new FileExistsResponse(false, null);
            else return new FileExistsResponse(true, item.RemoteUrl);
        }

        //todo: 做好校验，参考OSS的接口，防止被滥用
        //todo：应该由应用服务器向fileserver申请一个上传码（可以指定申请的个数，这个接口只能供应用服务器调用），
        //页面直传只能使用上传码上传一个文件，防止接口被恶意利用。应用服务器要控制发放上传码的频率。
        //todo：再提供一个非页面直传的接口，供服务器用
        [HttpPost("Upload")]
        [RequestSizeLimit(100_000_000)]
        public async Task<ActionResult<Uri>> Upload([FromForm] UploadRequest request,
            CancellationToken cancellationToken = default)
        {
            var file=request.File;
            string fileName = file.FileName;
            await using Stream stream = file.OpenReadStream();
            var upItem = await _domainService.UploadAsync(stream, fileName, cancellationToken);
            _dbContext.Add(upItem);
            return upItem.RemoteUrl;
        }
    }
}
