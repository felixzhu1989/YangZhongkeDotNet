using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleMySqlMcc
{
    public class HouseConfig:IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.Owner).IsConcurrencyToken();
        }
    }
}
