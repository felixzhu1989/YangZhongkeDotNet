using MediatR;
using Users.Domain;
using Users.Domain.Events;
using Users.Infrastructure;

namespace Users.WebApi
{
    //监听UserAccessResultEvent事件，并处理事件
    public class UserAccessResultEventHandler : INotificationHandler<UserAccessResultEvent>
    {

        private readonly IUserRepository _userRepository;
        private readonly UserDbContext _userDbContext;
        public UserAccessResultEventHandler(IUserRepository userRepository, UserDbContext userDbContext)
        {
            _userRepository = userRepository;
            _userDbContext = userDbContext;
        }

        /*//如果发现有生命周期引用范围报错的问题，可以使用创建生命周期解决
        //由于IUserRepository和UserDbContext的生命周期是Scoped
        //而Handler的生命周期是Transient,因此需要建立一个生命周期范围
        private readonly IServiceScopeFactory _scopeFactory;
        public UserAccessResultEventHandler(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }*/


        public async Task Handle(UserAccessResultEvent notification, CancellationToken cancellationToken)
        {
            /*//创建一个范围
            using var scope = _scopeFactory.CreateScope();
            //在这个范围内获取依赖注入,Required服务必须有
            var userRepository = scope.ServiceProvider.GetRequiredService<IUserRepository>();
            var userDbContext = scope.ServiceProvider.GetRequiredService<UserDbContext>();*/

            //调用领域层的方法
            await _userRepository.AddNewLoginHistoryAsync(notification.PhoneNumber, $"登录结果是：{notification.Result}");
            //因为这里不是控制器，不会通过过滤器自动提交，因此需要手动提交保存
            await _userDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
