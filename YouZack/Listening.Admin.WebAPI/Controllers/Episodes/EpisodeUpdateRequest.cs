using FluentValidation;
using Listening.Infrastructure;

namespace Listening.Admin.WebAPI.Controllers.Episodes
{
    /// <summary>
    /// Episode的音频不能修改，否则会让代码复杂很多，主流视频网站也都是这样干的。
    /// </summary>
    public record EpisodeUpdateRequest(MultilingualString Name, string SubtitleType,string Subtitle);
    public class EpisodeUpdateRequestValidator : AbstractValidator<EpisodeUpdateRequest>
    {
        public EpisodeUpdateRequestValidator(ListeningDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name.Chinese).NotNull().Length(1,200);
            RuleFor(x => x.Name.English).NotNull().Length(1, 200);
            RuleFor(x => x.SubtitleType).NotEmpty().Length(1, 10);
            RuleFor(x => x.Subtitle).NotEmpty().NotNull();
        }
    }
}
