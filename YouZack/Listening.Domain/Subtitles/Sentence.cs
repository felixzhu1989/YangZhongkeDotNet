namespace Listening.Domain.Subtitles
{
    //单条字幕，开始时间，结束时间，内容
    public record Sentence(TimeSpan StartTime, TimeSpan EndTime, string Content);
}
