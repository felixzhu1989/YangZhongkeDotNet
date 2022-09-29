using FluentValidation;

namespace Listening.Admin.WebAPI.Controllers.Categories
{
    //定义只是偶然和CategoryAddRequest一样，所以不应该复用它，只需要拷贝代码即可
    public record CategoryUpdateRequest(MultilingualString Name, Uri CoverUrl);
    public class CategoryUpdateRequestValidator : AbstractValidator<CategoryUpdateRequest>
    {
        public CategoryUpdateRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.CoverUrl).Length(5, 500);//CoverUrl允许为空
            RuleFor(x => x.Name.Chinese).NotNull().Length(1, 200);
            RuleFor(x => x.Name.English).NotNull().Length(1, 200);
        }
    }
}
