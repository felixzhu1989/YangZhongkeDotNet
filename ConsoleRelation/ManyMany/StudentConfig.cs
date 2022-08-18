using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleRelation.ManyMany
{
    public class StudentConfig:IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //ToTable指定中间表的名字
            builder.HasMany<Teacher>(s => s.Teachers).WithMany(t => t.Students)
                .UsingEntity(r => r.ToTable("Students_Teachers"));
        }
    }
}
