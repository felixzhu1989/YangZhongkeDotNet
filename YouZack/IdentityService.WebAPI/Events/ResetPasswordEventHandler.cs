using IdentityService.Domain;
using Zack.EventBus;

namespace IdentityService.WebAPI.Events
{
    //RabbitMQ集成事件，将收到的Json字符串序列化为字符串
    [EventName("IdentityService.User.PasswordReset")]
    public class ResetPasswordEventHandler:JsonIntegrationEventHandler<ResetPasswordEvent>
    {
        private readonly ILogger<ResetPasswordEventHandler> _logger;
        private readonly ISmsSender _smsSender;
        public ResetPasswordEventHandler(ILogger<ResetPasswordEventHandler> logger,ISmsSender smsSender)
        {
            _logger = logger;
            _smsSender = smsSender;
        }
        public override Task HandleJson(string eventName, ResetPasswordEvent? eventData)
        {
            _logger.LogInformation($"发送密码给用户手机：{eventData.PhoneNumber}");
            //发送密码给用户的手机
            return _smsSender.SendAsync(eventData.PhoneNumber, eventData.Password);
        }
    }
}
