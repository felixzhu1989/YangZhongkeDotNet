using Microsoft.EntityFrameworkCore;

namespace ConsoleExpression
{
    public class MyDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connStr = @"Server=PDMSERVER\SQLEXPRESS; Database=EFCoreTestDB; User Id = sa; Password=Epdm2018;TrustServerCertificate=true;MultipleActiveResultSets = true";
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
