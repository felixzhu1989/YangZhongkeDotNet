using FluentValidation;
using Listening.Infrastructure;

namespace Listening.Admin.WebAPI.Controllers.Albums
{
    public record AlbumAddRequest(MultilingualString Name,Guid CategoryId);
    public class AlbumAddRequestValidator:AbstractValidator<AlbumAddRequest>
    {
        public AlbumAddRequestValidator(ListeningDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name.Chinese).NotNull().Length(1,200);
            RuleFor(x => x.Name.English).NotNull().Length(1,200);
            //FluentValidation.AsyncValidatorInvokedSynchronouslyException: Validator "AlbumAddRequestValidator" can't be used with ASP.NET automatic validation as it contains asynchronous rules.不能用异步方法MustAsync，AnyAsync
            //验证CategoryId是否存在
            RuleFor(x => x.CategoryId).Must(cId =>
                dbContext.Query<Category>().Any(c => c.Id == cId))
                .WithMessage(c => $"CategoryId={c.CategoryId}不存在");
        }
    }
}
