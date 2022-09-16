using MediatR;

namespace WebApplicationMediatR
{
    public class PostNotificationHandler1:NotificationHandler<PostNotification>
    {
        //监听PostNotification发布的消息
        protected override void Handle(PostNotification notification)
        {
            Console.WriteLine($"1我收到了：{notification.Body}");
        }
    }
}
