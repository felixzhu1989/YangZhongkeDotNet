using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleRelation
{
    public class UserConfig:IEntityTypeConfiguration<User>  
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            
        }
    }
}
