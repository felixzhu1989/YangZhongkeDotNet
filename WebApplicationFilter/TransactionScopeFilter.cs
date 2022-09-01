using System.Transactions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationFilter
{
    public class TransactionScopeFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //context.ActionDescriptor是当前被执行的Action方法的描述信息
            //context.ActionArguments是当前被执行的Action方法的参数信息
            //ActionDescriptor转换成ControllerActionDescriptor类型，是Controller的方法才执行判断
            bool hasNotTransactionalAttribute = false;
            if (context.ActionDescriptor is ControllerActionDescriptor actionDesc)
            {
                hasNotTransactionalAttribute = actionDesc.MethodInfo.IsDefined(typeof(NotTransactionalAttribute), false);
            }
            if (hasNotTransactionalAttribute)//如果被标记了不启用事务控制，则直接执行方法
            {
                await next();
                return;
            }
            //如果没有被标记，则默认是启用事务控制
            using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            var result = await next();
            if (result.Exception==null) transactionScope.Complete();
        }
    }
}
