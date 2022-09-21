using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Users.Infrastructure
{
    //给数据库迁移用的设计时DbContextFactory
    public class DbContextFactory : IDesignTimeDbContextFactory<UserDbContext>
    {
        public UserDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UserDbContext>();
            var connStr =
                "Server=PDMSERVER\\SQLEXPRESS;Database=DDDSmallCaseDB;User Id=sa;Password=Epdm2018;TrustServerCertificate=true";
            builder.UseSqlServer(connStr);
            return new UserDbContext(builder.Options);
        }
    }
}
