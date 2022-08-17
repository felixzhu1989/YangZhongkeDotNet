using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleRelation
{
    public class LeaveConfig:IEntityTypeConfiguration<Leave>
    {
        public void Configure(EntityTypeBuilder<Leave> builder)
        {
            builder.HasOne<User>(l => l.Requester).WithMany().IsRequired();
            builder.HasOne<User>(l => l.Approver).WithMany();
        }
    }
}
