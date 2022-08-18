using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleRelation.SelfOneMany
{
    public class OrgUnitConfig : IEntityTypeConfiguration<OrgUnit>
    {
        public void Configure(EntityTypeBuilder<OrgUnit> builder)
        {
            builder.Property(o => o.Name).IsRequired().HasMaxLength(50);
            //因为根节点没有parent，因此不能修饰为IsRequired()
            builder.HasOne(o => o.Parent).WithMany(o => o.Children);
        }
    }
}
