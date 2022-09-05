using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace WebApplicationJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        //注入Identity中的UserManager
        private readonly UserManager<MyUser> _userManager;
        public IdentityController(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }

        //通过[FromServices]注入IOptions<JwtOptions>
        [HttpPost]
        [NotJwtVersionCheck]//标记登录方法不检查JwtVersion
        public async Task<IActionResult> Login(LoginRequest request, [FromServices] IOptions<JwtOptions> jwtOptions)
        {
            var userName = request.UserName;
            var password=request.Password;
            var user=await _userManager.FindByNameAsync(userName);
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
                claims.Add(new Claim(ClaimTypes.Role,role));
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
