using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Users.Domain.Entities;

namespace Users.Infrastructure.Configs
{
    public class UserLoginHistoryConfig:IEntityTypeConfiguration<UserLoginHistory>
    {
        public void Configure(EntityTypeBuilder<UserLoginHistory> builder)
        {
            //配置从属的值对象
            builder.OwnsOne(u => u.PhoneNumber, nb =>
            {
                nb.Property(p => p.RegionCode).HasMaxLength(5).IsUnicode(false);
                nb.Property(p => p.Number).HasMaxLength(20).IsUnicode(false);
            });
        }
    }
}
