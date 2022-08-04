using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ConsoleLogging
{
    public class Test
    {
        //使用当前类，在日志中提示记录日志的对象
        private readonly ILogger<Test> _logger;
        public Test(ILogger<Test> logger)
        {
            _logger = logger;
        }

        public void TestDebug()
        {
            //使用者无需关心日志输出的具体设置，只需要使用即可
            _logger.LogDebug("Start");
            _logger.LogDebug("Query");
            _logger.LogWarning("Warning");
            //模拟记录异常
           try
           {
               File.ReadAllText("A:/1.txt");
               _logger.LogDebug("Read file success");
           }
           catch (Exception e)
           {
               _logger.LogError(e, "Read file failed!");
           }

            //Serilog，要记录的结构化数据通过占位符来输
            _logger.LogWarning("新增用户{@person}", new { Id = 3, Name = "zack" });
        }
    }
}
