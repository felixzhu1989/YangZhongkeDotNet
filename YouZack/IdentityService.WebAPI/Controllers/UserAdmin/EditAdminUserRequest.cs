using FluentValidation;

namespace IdentityService.WebAPI.Controllers.UserAdmin
{
    public record EditAdminUserRequest(string PhoneNumber);
    public class EditAdminUserRequestValidator:AbstractValidator<EditAdminUserRequest>
    {
        public EditAdminUserRequestValidator()
        {
            RuleFor(e => e.PhoneNumber).NotNull().NotEmpty().MaximumLength(11);
        }
    }
}
