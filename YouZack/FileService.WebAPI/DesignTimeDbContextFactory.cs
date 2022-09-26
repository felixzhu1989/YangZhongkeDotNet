using CommonInitializer;
using FileService.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;

namespace FileService.WebAPI
{
    public class DesignTimeDbContextFactory:IDesignTimeDbContextFactory<FSDbContext>
    {
        public FSDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = DbContextOptionsBuilderFactory.Create<FSDbContext>();
            return new FSDbContext(optionsBuilder.Options, null);
        }
    }
}
