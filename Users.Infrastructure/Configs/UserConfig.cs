using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Users.Domain.Entities;

namespace Users.Infrastructure.Configs
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //配置从属的值对象
            builder.OwnsOne(u => u.PhoneNumber, nb =>
            {
                nb.Property(p => p.RegionCode).HasMaxLength(5).IsUnicode(false);
                nb.Property(p => p.Number).HasMaxLength(20).IsUnicode(false);
            });
            //成员变量映射到数据库
            builder.Property("passwordHash").HasMaxLength(100).IsUnicode(false);
            //指定一对一关系，并显式指定外键
            builder.HasOne(u => u.AccessFail).WithOne(a => a.User).HasForeignKey<UserAccessFail>(a => a.UserId);
        }
    }
}