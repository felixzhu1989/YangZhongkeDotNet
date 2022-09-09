using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace WebApplicationSignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        //注入Identity中的UserManager
        private readonly UserManager<MyUser> _userManager;
        private readonly IHubContext<MyHub> _myHubContext;
        public IdentityController(UserManager<MyUser> userManager, IHubContext<MyHub> myHubContext)
        {
            _userManager = userManager;
            _myHubContext = myHubContext;
        }

        //新增用户操作
        [HttpPost("AddUser")]
        [NotJwtVersionCheck]//标记登录方法不检查JwtVersion
        public async Task<ActionResult> AddUser(AddUserRequest request)
        {
            MyUser user = new MyUser { UserName = request.UserName, Email = request.Email };
            await _userManager.CreateAsync(user, request.Password);
            //调用SignalR群发消息
            await _myHubContext.Clients.All.SendAsync("ReceiveMessage", $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} | 系统消息 : 欢迎{user.UserName}加入我们！");
            return Ok();
        }

        [HttpPost("SendToken")]
        [NotJwtVersionCheck]//标记登录方法不检查JwtVersion
        public async Task<ActionResult> SendToken(string userName)
        {
            //发送重置密码的Token（验证码）
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) return BadRequest($"{userName}用户不存在");
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            //直接输出给用户，正常情况是用过邮件或短信发送
            return Ok($"重置密码的验证码是{token}");
        }

        [HttpPut("ResetPwd")]
        [NotJwtVersionCheck]//标记登录方法不检查JwtVersion
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

        //通过[FromServices]注入IOptions<JwtOptions>
        [HttpPost("Login")]
        [NotJwtVersionCheck]//标记登录方法不检查JwtVersion
        public async Task<IActionResult> Login(LoginRequest request, [FromServices] IOptions<JwtOptions> jwtOptions)
        {
            var userName = request.UserName;
            var password = request.Password;
            var user = await _userManager.FindByNameAsync(userName);
            //验证用户是否存在
            if (user == null) return NotFound($"{userName}用户不存在");
            if (await _userManager.IsLockedOutAsync(user)) return BadRequest($"{userName}被锁定，请稍后重试，锁定结束时间{user.LockoutEnd}");
            //验证密码是否正确
            var success = await _userManager.CheckPasswordAsync(user, password);
            if (!success)
            {
                //记录登录一次失败失败计数
                await _userManager.AccessFailedAsync(user);
                return BadRequest("登录失败！");
            }

            //登录成功，重置登录失败计数
            await _userManager.ResetAccessFailedCountAsync(user);
            //登录成功，JwtVersion自增
            user.JwtVersion++;
            await _userManager.UpdateAsync(user);//提交修改
            //将用户信息写入JWT的payload中
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                //将JwtVersion写入JWT令牌的payload中
                new Claim(ClaimTypes.Version, user.JwtVersion.ToString())
            };
            //获取用户所有角色，将roles信息写入jwt
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var jwtToken = BuildToken(claims, jwtOptions.Value);
            return Ok(jwtToken);
        }
        //封装获取JwtToken的方法
        private string BuildToken(IEnumerable<Claim> claims, JwtOptions options)
        {
            //通过配置读取Key和过期时间
            var expires = DateTime.Now.AddSeconds(options.ExpireSeconds);
            //HmacSha256生成jwt字符串过程
            var secBytes = Encoding.UTF8.GetBytes(options.SigningKey);
            var secKey = new SymmetricSecurityKey(secBytes);
            var credentials = new SigningCredentials(secKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(claims: claims, expires: expires, signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }
}
