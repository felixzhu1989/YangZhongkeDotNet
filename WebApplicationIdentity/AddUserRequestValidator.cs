using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace WebApplicationIdentity
{
    public class AddUserRequestValidator:AbstractValidator<AddUserRequest>
    {
        public AddUserRequestValidator(UserManager<MyUser> userManager)
        {
            RuleFor(x => x.UserName).NotNull().Length(3,10)
                .Must(x=>userManager.FindByNameAsync(x)==null)
                .WithMessage(x=>$"用户名{x.UserName}已经存在");
            RuleFor(x => x.Password).MinimumLength(3);
            RuleFor(x => x.Password2).Equal(x => x.Password)
                .WithMessage(x=>$"两次密码{x.Password}和{x.Password2}不一致");
            //Must自定义校验规则，限定邮箱为163或qq，WithMessage自定义错误信息
            RuleFor(x => x.Email).NotNull()
                .EmailAddress().WithMessage("请输入合法的邮箱地址")
                .Must(x=>x.EndsWith("@163.com")||x.EndsWith("@qq.com")).WithMessage("只支持163和qq邮箱");
        }
    }
}
