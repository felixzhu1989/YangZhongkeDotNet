using FluentValidation;

namespace IdentityService.WebAPI.Controllers.Login
{
    public record ChangeMyPasswordRequest(string Password, string Password2);
    public class ChangeMyPasswordRequestValidator:AbstractValidator<ChangeMyPasswordRequest>
    {
        public ChangeMyPasswordRequestValidator()
        {
            RuleFor(e => e.Password).NotNull().NotEmpty()
                .Equal(e => e.Password2);//两次输入的密码必须相等
            RuleFor(e => e.Password2).NotNull().NotEmpty();
        }
    }
}
