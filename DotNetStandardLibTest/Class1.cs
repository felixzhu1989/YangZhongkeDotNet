using System;
using System.IO;

namespace DotNetStandardLibTest
{
    public class Class1
    {
        public static void Test()
        {
            Console.WriteLine(typeof(FileStream).Assembly.Location);//打印FileStream所在程序集的位置
            Console.WriteLine(typeof(Class1).Assembly.Location);
        }
    }
}
