using Users.Domain.Entities;
using Users.Domain.Events;
using Users.Domain.ValueObject;

namespace Users.Domain
{
    //领域服务
    public class UserDomainService
    {
        private readonly IUserRepository _userRepository;
        private readonly ISmsCodeSender _smsCodeSender;

        public UserDomainService(IUserRepository userRepository,ISmsCodeSender smsCodeSender)
        {
            _userRepository = userRepository;
            _smsCodeSender = smsCodeSender;
        }
        //使用密码登录
        public async Task<UserAccessResult> CheckPasswordAsync(PhoneNumber phoneNumber, string password)
        {
            var user = await _userRepository.FindOneAsync(phoneNumber);//获取用户
            UserAccessResult result;
            if (user == null) result = UserAccessResult.PhoneNumberNotFound;//用户不存在
            else if (IsLockOut(user)) result = UserAccessResult.LockOut;//用户被锁定
            else if (!user.HasPassword()) result = UserAccessResult.NoPassword;//用户没有设定密码
            else if (user.CheckPassword(password)) result = UserAccessResult.Ok; //登录成功
            else result = UserAccessResult.PasswordError;//密码错误
            //响应结果的实际状态
            if (user != null)
            {
                if(result==UserAccessResult.Ok) ResetAccessFail(user);//登录成功，重设锁定状态
                else AccessFail(user); //处理登录失败
            }
            //发布登录结果消息
            var eventItem = new UserAccessResultEvent(phoneNumber, result);
            await _userRepository.PublishEventAsync(eventItem);
            return result;
        }
        //使用验证码登录
        public async Task<CheckCodeResult> CheckCodeAsync(PhoneNumber phoneNumber, string code)
        {
            var user = await _userRepository.FindOneAsync(phoneNumber);//获取用户
            if (user == null) return CheckCodeResult.PhoneNumberNotFound;//用户不存在
            if (IsLockOut(user)) return CheckCodeResult.LockOut;//用户被锁定
            //获取服务器中的验证码
            var codeInServer = await _userRepository.RetrievePhoneCodeAsync(phoneNumber);
            if (string.IsNullOrEmpty(codeInServer)) return CheckCodeResult.CodeError;
            if (code == codeInServer) return CheckCodeResult.Ok;
            else
            {
                AccessFail(user);
                return CheckCodeResult.CodeError;
            }
        }


        //聚合间，所有的操作都用过User聚合根，而不能直接操作AccessFail
        //因此需要定义一些转发方法
        private void ResetAccessFail(User user)
        {
            user.AccessFail.Reset();
        }

        private bool IsLockOut(User user)
        {
            return user.AccessFail.IsLockOut();
        }

        private void AccessFail(User user)
        {
            user.AccessFail.Fail();
        }
    }
}
