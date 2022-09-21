namespace Users.Domain.Entities
{
    public record UserAccessFail
    {
        public Guid Id { get; init; }
        public Guid UserId { get; init; }//用户Id，外键
        public User User { get; init; }//用户，同一个聚合中可以引用实体
        private bool lockOut;//是否被锁定
        public DateTime? LockOutEnd { get; private set; }//什么时候解除锁定
        public int AccessFailedCount { get; private set; }//已经登录错误的次数

        private UserAccessFail() { }//EF Core用
        public UserAccessFail(User user)
        {
            Id = Guid.NewGuid();
            User = user;
        }

        public void Reset()//重置
        {
            lockOut = false;
            LockOutEnd = null;
            AccessFailedCount = 0;
        }

        public void Fail() //处理一次登录失败
        {
            AccessFailedCount++;//登录错误次数自增
            if (AccessFailedCount >= 3)//错误3次就锁定
            {
                lockOut = true;
                LockOutEnd = DateTime.Now.AddMinutes(5);//锁定5分钟
            }
        }

        public bool IsLockOut()//判断是否已经锁定
        {
            if (lockOut)
            {
                if (LockOutEnd >= DateTime.Now) return true;
                else
                {
                    Reset();
                    return false;
                }
            }
            else return false;
        }
    }
}
