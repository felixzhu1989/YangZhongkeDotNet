﻿using FluentValidation;

namespace IdentityService.WebAPI.Controllers.Login
{
    public record LoginByPhoneAndPwdRequest(string PhoneNumber,string Password);
    public class LoginByPhoneAndPwdRequestValidator:AbstractValidator<LoginByPhoneAndPwdRequest>
    {
        public LoginByPhoneAndPwdRequestValidator()
        {
            RuleFor(e => e.PhoneNumber).NotNull().NotEmpty();
            RuleFor(e => e.Password).NotNull().NotEmpty();
        }
    }
}
