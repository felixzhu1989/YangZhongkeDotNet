using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemServices
{
    public class Test2
    {
        //使用当前类，在日志中提示记录日志的对象
        private readonly ILogger<Test2> _logger;
        public Test2(ILogger<Test2> logger)
        {
            _logger = logger;
        }

        public void TestDebug()
        {
            //使用者无需关心日志输出的具体设置，只需要使用即可
            _logger.LogDebug("StartTest2");
            _logger.LogDebug("QueryTest2");
            _logger.LogWarning("WarningTest2");
            //模拟记录异常
            try
            {
                File.ReadAllText("A:/1.txt");
                _logger.LogDebug("Read file success,Test2");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Read file failed!Test2");
            }
        }
    }
}
