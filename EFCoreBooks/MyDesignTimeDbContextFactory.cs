using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreBooks
{
    public class MyDesignTimeDbContextFactory:IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            //这里仅供EfCoreTools数据库迁移add-migration使用，正式项目不会用到这个类
            //想方设法连上开发数据库，不要管是否优美
            //将连接字符串放到项目属性-环境变量中
            DbContextOptionsBuilder<MyDbContext> builder = new DbContextOptionsBuilder<MyDbContext>();
            //var connStr = Environment.GetEnvironmentVariable("ConnStr");
            var connStr = "Server=PDMSERVER\\SQLEXPRESS;Database=EFCoreTestDB;User Id=sa;Password=Epdm2018;TrustServerCertificate=true;MultipleActiveResultSets=true";
            builder.UseSqlServer(connStr);
            return new MyDbContext(builder.Options);
        }
    }
}
