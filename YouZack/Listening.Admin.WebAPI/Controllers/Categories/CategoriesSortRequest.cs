using FluentValidation;

namespace Listening.Admin.WebAPI.Controllers.Categories
{
    public record CategoriesSortRequest
    {
        public Guid[] SortedCategoryIds { get; set; }//排序后的类别Id
    }
    public class CategoriesSortRequestValidator:AbstractValidator<CategoriesSortRequest>
    {
        public CategoriesSortRequestValidator()
        {
            RuleFor(x => x.SortedCategoryIds).NotNull().NotEmpty().NotContains(Guid.Empty).NotDuplicated();
        }
    }
}
