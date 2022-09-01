using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMySqlMcc
{
    public class House
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Owner { get; set; }
    }
}
