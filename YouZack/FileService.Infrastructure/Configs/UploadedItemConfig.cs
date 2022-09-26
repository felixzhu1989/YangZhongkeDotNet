using FileService.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FileService.Infrastructure.Configs
{
    public class UploadedItemConfig:IEntityTypeConfiguration<UploadedItem>
    {
        public void Configure(EntityTypeBuilder<UploadedItem> builder)
        {
            builder.ToTable("T_FS_UploadedItems");
            //因为SQLServer对于Guid主键默认创建聚集索引，因此会造成每次插入新数据，都会数据库重排。
            //因此我们取消主键的默认的聚集索引
            builder.HasKey(e => e.Id).IsClustered(false);
            builder.Property(e => e.FileName).IsUnicode().HasMaxLength(1024);
            builder.Property(e=>e.FileSHA256Hash).IsUnicode(false).HasMaxLength(64);
            //经常要按照这两个列进行查询，因此把它们两个组成【复合索引】，提高查询效率。
            builder.HasIndex(e => new { e.FileSHA256Hash, e.FileSizeInBytes });
            //数据库优化最先想到的就是索引（索引就是一种缓存），网站优化最先想到的就是缓存
        }
    }
}