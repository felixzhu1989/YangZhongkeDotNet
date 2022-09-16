using MediatR;

namespace WebApplicationMediatR
{
    //多个监听者，同时监听PostNotification发出的消息
    public class PostNotificationHandler2:NotificationHandler<PostNotification>
    {
        protected override void Handle(PostNotification notification)
        {
            Console.WriteLine($"2我也收到了：{notification.Body}");
        }
    }
}
