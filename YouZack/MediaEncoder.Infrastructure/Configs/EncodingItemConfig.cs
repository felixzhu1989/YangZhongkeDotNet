using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaEncoder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediaEncoder.Infrastructure.Configs
{
    class EncodingItemConfig:IEntityTypeConfiguration<EncodingItem>
    {
        public void Configure(EntityTypeBuilder<EncodingItem> builder)
        {
            builder.ToTable("T_ME_EncodingItems");
            //todo:id需要非聚集索引。
            builder.HasKey(x => x.Id).IsClustered(false);//对于Guid主键，不要建聚集索引，否则插入性能很差
            //todo:组合索引。
            builder.HasIndex(x => new { x.FileSHA256Hash, x.FileSizeInBytes });//组合索引
            builder.Property(x => x.Name).HasMaxLength(256);
            builder.Property(x => x.FileSHA256Hash).HasMaxLength(64).IsUnicode(false);
            builder.Property(x => x.OutputFormat).HasMaxLength(10).IsUnicode(false);
            builder.Property(x => x.Status).HasConversion<string>().HasMaxLength(10);//将枚举值存储为字符串
        }
    }
}
