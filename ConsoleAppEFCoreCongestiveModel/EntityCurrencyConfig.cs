using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppEFCoreCongestiveModel
{
    public class EntityCurrencyConfig:IEntityTypeConfiguration<EntityCurrency>
    {
        public void Configure(EntityTypeBuilder<EntityCurrency> builder)
        {
            //将枚举值属性添加转换器,转换成string类型,并限制字符串长度为5
            builder.Property(e => e.Currency).HasConversion<string>().HasMaxLength(5);
        }
    }
}
