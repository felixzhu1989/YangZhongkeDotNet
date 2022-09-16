using MediatR;

namespace WebApplicationMediatR
{
    public class UserNameChangeNotificationHandler:NotificationHandler<UserNameChangeNotification>
    {
        //监听来自UserNameChangeNotification的事件
        protected override void Handle(UserNameChangeNotification notification)
        {
            Console.WriteLine($"修改了用户名字：{notification.NewName}，旧用户名：{notification.OldName}"); 
        }
    }
}
