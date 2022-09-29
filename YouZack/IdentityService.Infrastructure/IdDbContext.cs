using IdentityService.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.Infrastructure
{
    //NuGet安装：Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
    public class IdDbContext:IdentityDbContext<User,Role,Guid>
    {
        public IdDbContext(DbContextOptions<IdDbContext> options):base(options){}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            //NuGet安装：Install-Package Zack.Infrastructure
            builder.EnableSoftDeletionGlobalFilter();
        }
    }
}
