using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEFCoreCongestiveModel
{
    public class MyDbContext:DbContext
    {
       
        public DbSet<User> Users { get; set; }
        public DbSet<EntityCurrency> EntityCurrencies { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Merchandise> Merchandises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = @"Server=PDMSERVER\SQLEXPRESS; Database=EFCoreTestDB; User Id = sa; Password=Epdm2018;TrustServerCertificate=true;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connStr);
            //打开日志记录
            optionsBuilder.LogTo(Console.WriteLine);
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
