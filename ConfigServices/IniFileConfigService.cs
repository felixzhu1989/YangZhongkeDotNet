using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace ConfigServices
{
    public class IniFileConfigService : IConfigService
    {
        public string FilePath { get; set; }
        public string GetValue(string name)
        {
            return File.ReadAllLines(FilePath).Select(s => s.Split('=')).Select(strs => new { Name = strs[0], Value = strs[1] }).SingleOrDefault(kv => kv.Name==name)?.Value;
        }
    }
}
