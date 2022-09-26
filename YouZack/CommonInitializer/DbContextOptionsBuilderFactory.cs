using Microsoft.EntityFrameworkCore;

namespace CommonInitializer
{
    public class DbContextOptionsBuilderFactory
    {
        //NuGet安装：Install-Package Microsoft.EntityFrameworkCore.SqlServer
        public static DbContextOptionsBuilder<TDbContext> Create<TDbContext>() where TDbContext : DbContext
        {
            //数据库连接，配置环境变量，新建用户变量，DefaultDB:ConnStr
            var connStr = Environment.GetEnvironmentVariable("DefaultDB:ConnStr");
            //或者直接写死算了
            //var connStr2 = "Server=PDMSERVER\\SQLEXPRESS;Database=YouzackVNextDB;User Id=sa;Password=Epdm2018;TrustServerCertificate=true;MultipleActiveResultSets=true";
            var optionsBuilder = new DbContextOptionsBuilder<TDbContext>();
            optionsBuilder.UseSqlServer(connStr);
            return optionsBuilder;
        }
    }
}
