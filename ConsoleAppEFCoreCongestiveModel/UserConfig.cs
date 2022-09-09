using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppEFCoreCongestiveModel
{
    public class UserConfig:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //特征1无需配置
            //特征2无需配置
            //特征3，不属于属性的成员变量映射为数据列。builder.Property(“成员变量名”)
            builder.Property("passwordHash");
            //特征4，从数据列中读取值得只读属性。HasField(”成员变量”)
            builder.Property(u => u.Remark).HasField("remark");
            //特征5，有的属性不需要映到数据列，仅在运行时被使用。使用Ignore()来配置忽略这个属性。
            builder.Ignore(u => u.Tag);
        }
    }
}
