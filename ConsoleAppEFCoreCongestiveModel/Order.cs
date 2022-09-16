using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFCoreCongestiveModel
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreateDateTime { get; set; }//创建时间
        public double TotalAmount { get; set; }//总价格
        public List<OrderDetail> Details { get; set; } = new List<OrderDetail>(); //订单明细
        //购买商品，商品类型和商品数量
        public void AddDetail(int merchandiseId, int count)
        {
            //先判断是否存在，如果存在则增加count，如果不存在则添加新的商品
            var detail = Details.SingleOrDefault(d => d.MerchandiseId == merchandiseId);
            if (detail == null)
            {
                detail = new OrderDetail { MerchandiseId = merchandiseId, Count = count };
                Details.Add(detail);
            }
            else
            {
                detail.Count += count;//如果有则累加
            }

        }
    }
}
