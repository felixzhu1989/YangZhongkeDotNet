using Microsoft.EntityFrameworkCore;
using Users.Domain.Entities;

namespace Users.Infrastructure
{
    public class UserDbContext:DbContext
    {
        //只为聚合根配置DbSet，因为聚合之间都是用过聚合根进行交互
        public DbSet<User> Users { get; set; }
        public DbSet<UserLoginHistory> UserLoginHistories { get; set; }

        //将配置SQL Server的代码转移到program中
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //this.GetType().Assembly在当前类所在的程序集中解析所有实现了IEntityTypeConfiguration接口类
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

    }
}
