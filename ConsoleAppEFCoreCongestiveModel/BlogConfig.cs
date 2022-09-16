using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppEFCoreCongestiveModel
{
    public class BlogConfig:IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            //通过回调,限定字段的类型和长度
            builder.OwnsOne(b => b.Title, ba =>
            {
                ba.Property(t => t.Chinese).HasMaxLength(255);
                ba.Property(t => t.English).HasColumnType("varchar(255)");
            });
            builder.OwnsOne(b => b.Body, ba =>
            {
                ba.Property(b => b.English).HasColumnType("varchar(MAX)");
            });
        }
    }
}
