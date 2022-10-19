namespace Listening.Admin.WebAPI
{
    //待转码的Episode的内容
    public record EncodingEpisodeInfo(Guid Id, MultilingualString Name, Guid AlbumId,
        double DurationInSecond, string Subtitle, string SubtitleType, string Status);
}
