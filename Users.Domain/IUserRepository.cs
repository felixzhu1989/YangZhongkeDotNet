using Users.Domain.Entities;
using Users.Domain.Events;
using Users.Domain.ValueObject;

namespace Users.Domain
{
    public interface IUserRepository
    {
        Task<User?> FindOneAsync(PhoneNumber phoneNumber);
        Task<User?> FindOneAsync(Guid id);
        //增加一条记录，登录成功，登录失败
        Task AddNewLoginHistoryAsync(PhoneNumber phoneNumber, string msg);
        
        //保存验证码，使用验证码登录的情况
        Task SavePhoneCodeAsync(PhoneNumber phoneNumber, string code);
        //取出登录验证码
        Task<string?> RetrievePhoneCodeAsync(PhoneNumber phoneNumber);

        //发布一个事件，发布登录结果
        Task PublishEventAsync(UserAccessResultEvent eventData);
    }
}
