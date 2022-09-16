using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFCoreCongestiveModel
{
    public class EntityCurrency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CurrencyName Currency { get; set; }
    }

    public enum CurrencyName
    {
        CNY,USD,NZD
    }
}
