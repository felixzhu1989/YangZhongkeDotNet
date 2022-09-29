using FluentValidation;

namespace IdentityService.WebAPI.Controllers.UserAdmin
{
    public record AddAdminUserRequest(string UserName, string PhoneNumber);
    public class AddAdminUserRequestValidator:AbstractValidator<AddAdminUserRequest>
    {
        public AddAdminUserRequestValidator()
        {
            RuleFor(e => e.PhoneNumber).NotNull().NotEmpty().MaximumLength(11);
            RuleFor(e => e.UserName).NotNull().NotEmpty().MaximumLength(20).MinimumLength(2);
        }
    }
}
