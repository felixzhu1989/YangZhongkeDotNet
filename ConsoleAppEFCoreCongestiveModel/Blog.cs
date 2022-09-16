using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFCoreCongestiveModel
{
    public class Blog
    {
        public int Id { get; set; }
        public MultilingualString Title { get; set; }
        public MultilingualString Body { get; set; }
    }
}
