using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleRowVersion
{
    public class HouseConfig:IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.Property(b => b.Name).IsRequired();
            builder.Property(h => h.RowVer).IsRowVersion();
        }
    }
}
