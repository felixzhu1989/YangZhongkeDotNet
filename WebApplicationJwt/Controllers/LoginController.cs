using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace WebApplicationJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IOptionsSnapshot<JwtOptions> _jwtOptions;
        public LoginController(IOptionsSnapshot<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Login(string userName, string password)
        {
            if (userName == "felix" && password == "123456")
            {
                //不要存储太多东西在payload中，否则jwt字符串太长，浪费流量
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier,"1"));
                claims.Add(new Claim(ClaimTypes.Name,userName));
                claims.Add(new Claim(ClaimTypes.Role,"Admin"));
                claims.Add(new Claim(ClaimTypes.Role,"Viewer"));
                
                //通过配置读取Key和过期时间
                var key = _jwtOptions.Value.SigningKey;
                var expires = DateTime.Now.AddSeconds(_jwtOptions.Value.ExpireSeconds);
                //HmacSha256生成jwt字符串过程
                var secBytes = Encoding.UTF8.GetBytes(key);
                var secKey = new SymmetricSecurityKey(secBytes);
                var credentials = new SigningCredentials(secKey, SecurityAlgorithms.HmacSha256Signature);
                var tokenDescriptor = new JwtSecurityToken(claims: claims, expires: expires, signingCredentials: credentials);
                var jwt = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

                return await Task.FromResult(jwt);
            }
            else
            {
                return BadRequest("用户名或密码错误");
            }
        }
    }
}
