using IdentityService.Domain;
using Zack.EventBus;

namespace IdentityService.WebAPI.Events
{
    [EventName("IdentityService.User.Created")]
    public class UserCreatedEventHandler:JsonIntegrationEventHandler<UserCreatedEvent>
    {
        private readonly ILogger<UserCreatedEventHandler> _logger;
        private readonly ISmsSender _smsSender;
        public UserCreatedEventHandler(ILogger<UserCreatedEventHandler> logger,ISmsSender smsSender)
        {
            _logger = logger;
            _smsSender = smsSender;
        }
        public override Task HandleJson(string eventName, UserCreatedEvent? eventData)
        {
            _logger.LogInformation($"发送初始密码给被创建用户的手机：{eventData.PhoneNumber}");
            //发送初始密码给被创建用户的手机
            return _smsSender.SendAsync(eventData.PhoneNumber, eventData.Password);
        }
    }
}
