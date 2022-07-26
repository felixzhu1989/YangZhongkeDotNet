using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigServices
{
    public interface IConfigReader
    {
        /// <summary>
        /// 如果配置找不到就返回null
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        string GetValue(string name);
    }
}
