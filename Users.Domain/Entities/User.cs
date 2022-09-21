using Users.Domain.ValueObject;
using Zack.Commons;
using Zack.DomainCommons.Models;

namespace Users.Domain.Entities
{
    //聚合根，实现IAggregateRoot接口加以区分
    public record User : IAggregateRoot
    {
        public Guid Id { get; init; }
        public PhoneNumber PhoneNumber { get; private set; }//手机号
        private string? passwordHash;//密码散列值
        public UserAccessFail AccessFail { get; private set; }//用户登录失败

        private User() { } //供EF Core用
        public User(PhoneNumber phoneNumber)//创建用户时，必须有手机号
        {
            Id = Guid.NewGuid();
            PhoneNumber = phoneNumber;
            AccessFail = new UserAccessFail(this);
        }

        public bool HasPassword() //是否设置了密码
        {
            return !string.IsNullOrEmpty(passwordHash);
        }

        public void ChangePassword(string value)
        {
            if (value.Length <= 3) throw new ArgumentException("密码长度不能小于3");
            passwordHash = HashHelper.ComputeMd5Hash(value);
            //只是修改自己的passwordHash（自己的状态），而不完成数据持久化操作（保存数据库）
            //聚合中只维护自身状态，不与外部交互
            //这里暂时还没有触发领域时间，在做真实项目时最好注册领域事件
        }

        public bool CheckPassword(string password)//检查密码是否正确
        {
            return passwordHash == HashHelper.ComputeMd5Hash(password);
        }

        public void ChangePhoneNumber(PhoneNumber phoneNumber)//修改手机号码
        {
            PhoneNumber = phoneNumber;
        }
    }
}
