using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRelation
{
    public class Comment
    {
        public long Id { get; set; }
        public string Message { get; set; }
        //导航属性
        public Article Article { get; set; }
    }
}
