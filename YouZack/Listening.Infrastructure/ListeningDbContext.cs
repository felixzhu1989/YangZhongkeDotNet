using Listening.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Zack.Infrastructure.EFCore;

namespace Listening.Infrastructure
{
    public class ListeningDbContext:BaseDbContext
    {
        //不要忘了写set，否则拿到的DbContext的Categories为null
        public DbSet<Category> Categories { get;private set; }
        public DbSet<Album> Albums { get;private set; }
        public DbSet<Episode> Episodes { get;private set; }
        public ListeningDbContext(DbContextOptions options, IMediator? mediator) : base(options, mediator)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.EnableSoftDeletionGlobalFilter();
        }
    }
}
