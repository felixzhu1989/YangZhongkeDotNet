namespace Listening.Main.WebAPI.Controllers.Episodes
{
    //为了简化前端把TimeSpan格式字符串转换为毫秒数的麻烦，在服务器端直接把TimeSpan转换为double
    public record SentenceViewModel(double StartTime, double EndTime, string Content);
}
