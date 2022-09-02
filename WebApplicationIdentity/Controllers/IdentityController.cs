using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebApplicationIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        //注入两个manager
        private readonly UserManager<MyUser> _userManager;
        private readonly RoleManager<MyRole> _roleManager;
        public IdentityController(UserManager<MyUser> userManager, RoleManager<MyRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Test()
        {
            //判断有没有角色
            if (!await _roleManager.RoleExistsAsync("admin"))
            {
                var role = new MyRole { Name = "admin" };
                var result = await _roleManager.CreateAsync(role);
                if (!result.Succeeded) return BadRequest("RoleManager CreateAsync Failed");
            }
            //判断有没有用户
            var user = await _userManager.FindByNameAsync("felix");
            if (user == null)
            {
                user = new MyUser { UserName = "felix" };
                var result = await _userManager.CreateAsync(user, "123");
                if (!result.Succeeded) return BadRequest("UserManager CreateAsync Failed");
            }
            //判断用户属不属于角色
            if (!await _userManager.IsInRoleAsync(user, "admin"))
            {
                var result = await _userManager.AddToRoleAsync(user, "admin");
                if (!result.Succeeded) return BadRequest("UserManager AddToRoleAsync Failed");
            }
            return "OK";
        }

        [HttpPost]
        [Route("CheckPwd")]
        public async Task<ActionResult> CheckPwd(CheckPwdRequest request)
        {
            var userName = request.UserName;
            var password = request.Password;
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) return BadRequest($"{userName}不存在");
            if (await _userManager.IsLockedOutAsync(user)) return BadRequest($"{userName}被锁定，请稍后重试，锁定结束时间{user.LockoutEnd}");
            if (await _userManager.CheckPasswordAsync(user, password))
            {
                //重置登录失败计数
                await _userManager.ResetAccessFailedCountAsync(user);
                return Ok("登陆成功");
            }
            else
            {
                //记录登录一次失败失败计数,默认失败5次就锁定，锁定时间为5分钟
                //可在LockoutOptions中配置MaxFailedAccessAttempts和DefaultLockoutTimeSpan
                await _userManager.AccessFailedAsync(user);
                return BadRequest($"{userName}登录密码错误");
            }
        }

        [HttpPost]
        [Route("SendToken")]
        public async Task<ActionResult> SendToken(string userName)
        {
            //发送重置密码的Token（验证码）
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) return BadRequest($"{userName}用户不存在");
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            //直接输出给用户，正常情况是用过邮件或短信发送
            return Ok($"重置密码的验证码是{token}");
        }

        [HttpPut]
        public async Task<ActionResult> ResetPwd(string userName, string token, string newPwd)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) return BadRequest($"{userName}用户不存在");
            if (await _userManager.IsLockedOutAsync(user)) return BadRequest($"{userName}被锁定，请稍后重试，锁定结束时间{user.LockoutEnd}");
            //只有token正确，才能修改密码
            var result = await _userManager.ResetPasswordAsync(user, token, newPwd);
            if (result.Succeeded)
            {
                //重置登录失败计数
                await _userManager.ResetAccessFailedCountAsync(user);
                return Ok($"密码重置成功，{userName}请牢记新的登录密码:{newPwd}");
            }
            else
            {
                await _userManager.AccessFailedAsync(user);
                return BadRequest($"{userName}密码重置失败");
            }
        }
    }
}
