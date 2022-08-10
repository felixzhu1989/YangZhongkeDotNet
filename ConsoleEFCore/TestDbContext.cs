using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleEFCore
{
    public class TestDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            var connStr = @"Server=PDMSERVER\SQLEXPRESS; Database=EFCoreTestDB; User Id = sa; Password=Epdm2018;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connStr);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //this.GetType().Assembly在当前类所在的程序集中解析所有实现了IEntityTypeConfiguration接口类
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
