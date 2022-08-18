using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleRelation.OneOne
{
    public class DeliveryConfig:IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.HasOne<Order>(d=>d.Order).WithOne(o=>o.Delivery).HasForeignKey<Delivery>(d=>d.OrderId);
        }
    }
}
