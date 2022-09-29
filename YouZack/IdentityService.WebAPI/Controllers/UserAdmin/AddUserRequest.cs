using FluentValidation;

namespace IdentityService.WebAPI.Controllers.UserAdmin
{
    public record AddUserRequest(string UserName,string PhoneNumber, string RoleName);
    public class AddUserRequestValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserRequestValidator()
        {
            RuleFor(e => e.PhoneNumber).NotNull().NotEmpty().MaximumLength(11);
            RuleFor(e => e.UserName).NotNull().NotEmpty().MaximumLength(20).MinimumLength(2);
            RuleFor(e => e.RoleName).NotNull().NotEmpty();
        }
    }
}
