using Listening.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Listening.Infrastructure.Configs
{
    class EpisodeConfig:IEntityTypeConfiguration<Episode>
    {
        public void Configure(EntityTypeBuilder<Episode> builder)
        {
            builder.ToTable("T_Episodes");
            builder.HasKey(x => x.Id).IsClustered();
            builder.HasIndex(x => new{x.AlbumId,x.IsDeleted});
            builder.OwnsOneMultilingualString(x => x.Name);
            //尽量用标准的、Provider无关的这些FluentAPI去配置，不要和数据库耦合
            //如果真的需要在IEntityTypeConfiguration中判断数据库类型
            //那么就定义一个接口提供DbContext属性，仿照ApplyConfigurationsFromAssembly写一个给IEntityTypeConfiguration
            //实现类注入DbContext，然后Dbcontext.Database.IsSqlServer(); 
            builder.Property(x => x.AudioUrl).HasMaxLength(1000).IsUnicode().IsRequired();
            builder.Property(x => x.Subtitle).HasMaxLength(int.MaxValue).IsUnicode().IsRequired();
            builder.Property(x => x.SubtitleType).HasMaxLength(10).IsUnicode(false).IsRequired();
        }
    }
}
