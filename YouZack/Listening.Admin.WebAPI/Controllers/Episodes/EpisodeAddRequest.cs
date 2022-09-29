using FluentValidation;
using Listening.Infrastructure;

namespace Listening.Admin.WebAPI.Controllers.Episodes
{
    public record EpisodeAddRequest(MultilingualString Name,Guid AlbumId,Uri AudioUrl,double DurationInSecond,string Subtitle,string SubtitleType);
    public class EpisodeAddRequestValidator:AbstractValidator<EpisodeAddRequest>
    {
        public EpisodeAddRequestValidator(ListeningDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name.Chinese).NotNull().Length(1, 200);
            RuleFor(x => x.Name.English).NotNull().Length(1, 200);
            //验证AlbumId是否存在
            RuleFor(x => x.AlbumId).Must(cId =>
                    dbContext.Query<Category>().Any(c => c.Id == cId))
                .WithMessage(c => $"AlbumId={c.AlbumId}不存在");
            RuleFor(x => x.AudioUrl).NotEmptyUri().Length(1, 1000);
            RuleFor(x => x.DurationInSecond).GreaterThan(0);
            RuleFor(x => x.SubtitleType).NotEmpty().Length(1, 10);
            RuleFor(x => x.Subtitle).NotEmpty().NotNull();
        }
    }
}
