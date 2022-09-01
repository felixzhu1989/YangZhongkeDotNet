using Microsoft.EntityFrameworkCore;

namespace ConsoleRowVersion
{
    public class MyDbContext:DbContext
    {
        public DbSet<House> Houses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connStr = @"Server=PDMSERVER\SQLEXPRESS; Database=EFCoreRelationDB; User Id = sa; Password=Epdm2018;TrustServerCertificate=true;MultipleActiveResultSets = true";
            optionsBuilder.UseSqlServer(connStr);
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
