using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRelation.OneMany
{
    public class Comment
    {
        public long Id { get; set; }
        public string Message { get; set; }
        //导航属性
        public Article Article { get; set; }
        //额外外键字段
        public long ArticleId { get; set; }
    }
}
