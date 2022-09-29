using System.Text;
using SubtitlesParser.Classes.Parsers;

namespace Listening.Domain.Subtitles
{
    /// <summary>
    /// parser for *.srt files and *.vtt files
    /// </summary>
    class SrtParser :ISubtitleParser
    {
        public bool Accept(string typeName)
        {
            return typeName.Equals("srt", StringComparison.OrdinalIgnoreCase)
                   || typeName.Equals("vtt", StringComparison.OrdinalIgnoreCase);
        }

        public IEnumerable<Sentence> Parse(string subtitle)
        {
            //NuGet安装：Install-Package SubtitlesParser
            var srtParser = new SubParser();
            using MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(subtitle));
            var items = srtParser.ParseStream(ms);
            return items.Select(s=>new Sentence(TimeSpan.FromMilliseconds(s.StartTime),TimeSpan.FromMilliseconds(s.EndTime),string.Join(' ', s.Lines)));
        }
    }
}
