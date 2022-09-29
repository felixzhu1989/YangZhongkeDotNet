using Listening.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Listening.Infrastructure.Configs
{
    class CategoryConfig:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("T_Categories");
            builder.HasKey(x => x.Id).IsClustered();
            builder.OwnsOneMultilingualString(x => x.Name);
            builder.Property(x => x.CoverUrl).IsRequired(false).HasMaxLength(500).IsUnicode();
        }
    }
}
