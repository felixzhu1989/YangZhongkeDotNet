using System.Text;
using MarkdownSharp;

namespace WebApplicationMarkdown
{
    public class MarkdownMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _hostEnv;
        public MarkdownMiddleware(RequestDelegate next, IWebHostEnvironment hostEnv)
        {
            _next = next;
            _hostEnv = hostEnv;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path.ToString();
            //判断是不是一个Markdown文件，后缀.md，忽略大小写
            if (!path.EndsWith(".md",true,null))
            {
                await _next(context);
                return;
            }
            var file = _hostEnv.WebRootFileProvider.GetFileInfo(path);
            //判断wwwroot下是否有这个文件
            if (!file.Exists)
            {
                await _next(context);
                return;
            }
            //从流中读取文件，使用Ude.NetStandard探测流文本的编码格式
            await using var stream = file.CreateReadStream();
            var charsetDetector = new Ude.CharsetDetector();
            charsetDetector.Feed(stream);//读取流
            charsetDetector.DataEnd();
            var charset = charsetDetector.Charset??"UTF-8";//如果编码是空的则使用UTF-8
            stream.Position = 0;//将流的位置复原，因为上面的代码可能将流读到尾
            //因为你后面要重新读这个流
            using var reader = new StreamReader(stream, Encoding.GetEncoding(charset));
            var mdText= await reader.ReadToEndAsync();
            //MarkdownSharp包能够将Markdown格式转换成Html
            var md = new Markdown();
            var html = md.Transform(mdText);
            context.Response.ContentType = "text/html;charset=UTF-8";
            await context.Response.WriteAsync(html);
        }
    }
}
