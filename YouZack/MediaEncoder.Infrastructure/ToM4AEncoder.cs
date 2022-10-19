using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFmpeg.NET;
using MediaEncoder.Domain;

namespace MediaEncoder.Infrastructure
{
    public class ToM4AEncoder:IMediaEncoder
    {
        public bool Accept(string outputFormat)
        {
            return "m4a".Equals(outputFormat, StringComparison.OrdinalIgnoreCase);
        }
        public async Task EncodeAsync(FileInfo sourceFile, FileInfo destFile, string destFormat, string[]? args, CancellationToken ct)
        {
            //可以用“FFmpeg.AutoGen”，因为他是bingding库，不用启动独立的进程，更靠谱。
            //但是编程难度大，这里重点不是FFMPEG，所以先用命令行实现
            //Install-Package xFFmpeg.NET
            var inputFile =new InputFile(sourceFile);
            var outputFile = new OutputFile(destFile);
            string baseDir=AppContext.BaseDirectory;//程序运行根目录
            string ffmpegPath = Path.Combine(baseDir, "ffmpeg.exe");
            var ffmpeg = new Engine(ffmpegPath);
            string? errorMsg = null;
            ffmpeg.Error += (s, e) =>
            {
                errorMsg = e.Exception.Message;
            };
            await ffmpeg.ConvertAsync(inputFile, outputFile, ct);//进行转码
            if (errorMsg != null) throw new Exception(errorMsg);
        }
    }
}
