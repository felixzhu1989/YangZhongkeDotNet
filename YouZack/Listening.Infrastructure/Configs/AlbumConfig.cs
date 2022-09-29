using Listening.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Listening.Infrastructure.Configs
{
    //NuGet安装：Install-Package Microsoft.EntityFrameworkCore.SqlServer
    class AlbumConfig :IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("T_Albums");
            builder.HasKey(x=>x.Id).IsClustered(false);//对于Guid主键，不要建聚集索引，否则插入性能很差
            //NuGet安装：Install-Package Zack.Infrastructure
            builder.OwnsOneMultilingualString(x=>x.Name);
            builder.HasIndex(x => new { x.CategoryId, x.IsDeleted });//组合索引
        }
    }
}
