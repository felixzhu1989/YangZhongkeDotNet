using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBooks
{
    public class MyDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
            
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //不再这里写连接字符串和使用数据库，而是推迟到API项目中配置

        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //自动加载实体类的配置类
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
