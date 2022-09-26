using FileService.Domain.Entities;

namespace FileService.Infrastructure
{
    //NuGet安装：Install-Package Zack.Infrastructure
    public class FSDbContext:BaseDbContext
    {
        public DbSet<UploadedItem> UploadedItems { get;private set; }
        public FSDbContext(DbContextOptions options, IMediator? mediator) : base(options, mediator)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
