using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleRelation
{
    public class CommentConfig:IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(c => c.Message).IsRequired().IsUnicode();
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c=>c.ArticleId).IsRequired();
        }
    }
}
