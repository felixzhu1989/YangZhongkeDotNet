using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleRelation.OneMany
{
    public class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(a => a.Title).IsRequired().IsUnicode().HasMaxLength(255);
            builder.Property(a => a.Content).IsRequired().IsUnicode();
            builder.HasQueryFilter(a => a.IsDeleted == false);
            //builder.HasMany<Comment>(a=>a.Comments).WithOne(c=>c.Article).HasForeignKey(c=>c.ArticleId).IsRequired();
        }
    }
}
