using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace WebApplicationSignalR
{
    [Authorize]
    public class MyHub : Hub
    {
        private readonly UserManager<MyUser> _userManager;
        public MyHub(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }

        public Task SendMessage(string message)
        {
            var claim = Context.User!.FindFirst(ClaimTypes.Name);
            //Debug.Print(claim!.Value);//拿到请求者的Name
            //将消息拼接转移到web api中
            var msgToSend = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} | {claim!.Value} : {message}";
            return Clients.All.SendAsync("ReceiveMessage", msgToSend);

            //var connId = Context.ConnectionId;//拿到连接的客户端Id
            //Clients.AllExcept(connId);//所有的，除了
            //Clients.Caller //自己
            //await Groups.AddToGroupAsync(connId, "dev"); //将当前连接加入组
            //Clients.Group("dev") //群组，先加入组
            //Clients.Others //其他人
            //Clients.OthersInGroup("dev") //某个组的其他人
        }

        public async Task SendPrivateMessage(string toUserName, string message)
        {
            //查找接收人
            var destUser = await _userManager.FindByNameAsync(toUserName);
            //获取发送消息的人
            var claim = Context.User!.FindFirst(ClaimTypes.Name);
            var msgToSend = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} | {claim!.Value.ToLower()} => {toUserName.ToLower()} : {message}";
            //根据用户Id，过滤发送消息的人
            await Clients.User(destUser.Id.ToString()).SendAsync("ReceivePrivateMessage",  msgToSend);
        }


    }
}
