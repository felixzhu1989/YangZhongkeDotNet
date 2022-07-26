using System;
using System.Collections.Generic;
using System.Text;

namespace LogServices
{
    //使用扩展方法以后，这个类可以不适用public
    class ConsoleLogProvider : ILogProvider
    {
        public void LogError(string msg)
        {
            Console.WriteLine($"Error:{msg}");
        }

        public void LogInfo(string msg)
        {
            Console.WriteLine($"Info:{msg}");
        }
    }
}
