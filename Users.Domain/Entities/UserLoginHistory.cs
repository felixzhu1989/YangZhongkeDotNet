using Users.Domain.ValueObject;
using Zack.DomainCommons.Models;

namespace Users.Domain.Entities
{
    public record UserLoginHistory:IAggregateRoot
    {
        public long Id { get; init; }
        //聚合之间的实体不要直接引用实体，而是通过标识符
        //UserId是一个指向User实体的外键，但是物理上并没有创建它们的外键关系
        //有可能今后会拆分成多个微服务，他们两个实体不在同一个数据库中
        public Guid? UserId { get; init; }
        public PhoneNumber PhoneNumber { get; init; }
        public DateTime CreateDateTime { get; init; }
        public string Message { get; init; }//消息，登录成功，登录失败等等

        private UserLoginHistory() { }
        public UserLoginHistory(Guid? userId,PhoneNumber phoneNumber,string message)
        {
            UserId=userId;
            PhoneNumber=phoneNumber;
            CreateDateTime=DateTime.Now;
            Message=message;
        }
    }
}
