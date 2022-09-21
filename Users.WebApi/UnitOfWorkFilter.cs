using System.Data.Common;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace Users.WebApi
{
    public class UnitOfWorkFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {

            var result = await next();
            if (result.Exception!=null) return;//只有Action执行成功(没有发生异常)，才自动调用SaveChangesAsync
            var actionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
            if (actionDescriptor==null) return;//不是ControllerActionDescriptor不处理
            var unitOfWorkAttribute = actionDescriptor.MethodInfo.GetCustomAttribute<UnitOfWorkAttribute>();
            if (unitOfWorkAttribute==null) return;//没有标注UnitOfWorkAttribute则不处理
            foreach (var dbContextType in unitOfWorkAttribute.DbContextTypes)
            {
                //管DI要dbContext实例,如果能拿到就执行SaveChangesAsync
                if (context.HttpContext.RequestServices.GetService(dbContextType) is DbContext dbContext) await dbContext.SaveChangesAsync();
            }
        }
    }
}
