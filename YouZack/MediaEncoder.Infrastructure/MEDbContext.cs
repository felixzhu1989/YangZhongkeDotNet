using MediaEncoder.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Zack.Infrastructure.EFCore;

namespace MediaEncoder.Infrastructure
{
    public class MEDbContext:BaseDbContext
    {
        public DbSet<EncodingItem> EncodingItems { get; set; }
        public MEDbContext(DbContextOptions<MEDbContext> options, IMediator mediator) : base(options, mediator)
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