using MediatR;

namespace WebApplicationMediatR
{
    public class NewUserNotificationHandler:NotificationHandler<NewUserNotification>
    {
        //监听来自NewUserNotification的事件
        protected override void Handle(NewUserNotification notification)
        {
            //这里只是在控制台输出了一下，可能实际业务中有更多的操作
            Console.WriteLine($"新建了用户：{notification.Name}，时间：{notification.CreateTime}");
        }
    }
}
