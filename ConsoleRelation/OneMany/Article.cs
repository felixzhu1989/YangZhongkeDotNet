using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRelation.OneMany
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public double Price { get; set; }
        public bool IsDeleted { get; set; }//默认值未false，数据库中为0
        //导航属性
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
