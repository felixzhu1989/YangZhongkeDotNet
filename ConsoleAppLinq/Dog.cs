using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinq
{
    public class Dog
    {
        public string NickName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"NickName={NickName},Age={Age}";
        }
    }
}
