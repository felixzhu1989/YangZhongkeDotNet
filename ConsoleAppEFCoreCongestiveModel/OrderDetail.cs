using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFCoreCongestiveModel
{
    public class OrderDetail
    {
        public int Id { get; set; }
        //与订单是一对多的关系
        public Order Order { get; set; }
        public string Name { get; set; }

        //public Merchandise Merchandise { get; set; }
        //跨聚合进行实体引用，只能引用根实体，并且只能引用根实体的主键
        public int MerchandiseId { get; set; }
        public int Count { get; set; }
    }
}
