using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Users.Domain;
using Users.Infrastructure;

namespace Users.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserDomainService _userService;
        public LoginController(UserDomainService userService)
        {
            _userService = userService;
        }

        //使用密码登录
        [HttpPost("password")]
        //存在修改数据的操作，记得添加提交事务工作单元特性
        [UnitOfWork(typeof(UserDbContext))]
        public async Task<IActionResult> LoginByPassword(LoginByPasswordRequest request)
        {
            if (request.Password.Length < 3) return BadRequest("密码长度至少为3位");
            var result=  await _userService.CheckPasswordAsync(request.PhoneNumber, request.Password);
            switch (result)
            {
                case UserAccessResult.Ok:
                    return Ok("登录成功");//此处只是简单展示，实际有返回报文格式，请自行定义Response
                case UserAccessResult.LockOut:
                    return BadRequest("账户被锁定了,请稍后尝试登录");
                case UserAccessResult.NoPassword:
                case UserAccessResult.PasswordError:
                case UserAccessResult.PhoneNumberNotFound:
                    return BadRequest("登录失败");//无需告诉前端为什么失败，防止信息泄露
                default:
                    throw new ApplicationException($"未知值{result}");//抛出异常，方便今后修复Bug
            }
        }
    }
}
