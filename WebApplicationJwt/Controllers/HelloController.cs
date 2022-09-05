using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] //表示该控制器下所有方法都需要登录才能访问
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            //获取当前登录的Id，用户名，角色等信息
            var id = this.User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            var userName = this.User.FindFirst(ClaimTypes.Name)!.Value;
            var roles = this.User.FindAll(ClaimTypes.Role);
            var roleNames = string.Join(',', roles.Select(r => r.Value));
            return Ok($"UserId:{id},UserName:{userName},UserRoles:{roleNames}");
        }

        [HttpGet("666")]
        [AllowAnonymous]//允许该方法在不登录的用户可访问
        public ActionResult<string> Get666()
        {
            return Ok("666");
        }

        [HttpGet("Admin")]
        [Authorize(Roles = "Admin,admin")]//允许管理员才能访问的方法
        public ActionResult<string> GetAdmin()
        {
            return Ok("Hello Admin");
        }
    }
}
