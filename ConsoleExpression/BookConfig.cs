using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleExpression
{
    //约定大于配置，可以不配置
    public class BookConfig:IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //builder.ToTable("T_Books");//约定数据表的名字
            builder.Property(b => b.Title).HasMaxLength(50).IsRequired();
            builder.Property(b => b.AuthorName).HasMaxLength(20).IsRequired();
        }
    }
}
