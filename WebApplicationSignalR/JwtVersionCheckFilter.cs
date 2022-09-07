using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationSignalR
{
    /// <summary>
    /// 检查JwtVersion中间件
    /// </summary>
    public class JwtVersionCheckFilter : IAsyncActionFilter
    {
        private readonly UserManager<MyUser> _userManager;
        public JwtVersionCheckFilter(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //判断是否加了NotJwtVersionCheckAttribute，不检查JwtVersion
            var actionDesc = context.ActionDescriptor as ControllerActionDescriptor;
            if (actionDesc == null)
            {
                await next();
                return;
            }
            if (actionDesc.MethodInfo.GetCustomAttributes(typeof(NotJwtVersionCheckAttribute), false).Any())
            {
                await next();
                return;
            }
            //Todo：不用每次都去服务器查询用户，获取服务端JwtVersion，否则性能太低了，可以使用缓存优化
            var claimUserName = context.HttpContext.User.FindFirst(ClaimTypes.Name);
            var user = await _userManager.FindByNameAsync(claimUserName.Value);
            if (user == null)
            {
                context.Result = new ObjectResult($"{claimUserName.Value}用户不存在") { StatusCode = 400 };
                return;
            }
            //获取客户端中的JwtVersion
            var claimVersion = context.HttpContext.User.FindFirst(ClaimTypes.Version);
            if (claimVersion == null)
            {
                context.Result = new ObjectResult("payload中没有JwtVersion") { StatusCode = 400 };
                return;
            }
            var jwtVersionFromClient = long.Parse(claimVersion.Value);
            //比较服务器端和用户端JwtVersion的大小，如果服务器端更大则说明Jwt令牌过期了
            if (user.JwtVersion > jwtVersionFromClient)
            {
                context.Result = new ObjectResult("登录信息已经过期了，请重新登录") { StatusCode = 400 };
                return;
            }
            //不要遗漏next()
            await next();
        }
    }
}
