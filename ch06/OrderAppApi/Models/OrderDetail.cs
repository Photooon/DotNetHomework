using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    [Serializable]
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }
        public int CommodityId { get; set; }

        [Required]
        public int Count { get; set; }
        [Required]
        public float Discount { get; set; }

        // 一对一映射
        public Commodity Commodity { get; set; }

        public double Money => Math.Round(Commodity.Price * Count * Discount, 2);

        public OrderDetail() { }

        public OrderDetail(int orderDetailId, int commodityId, int count, float Discount)
        {
            this.OrderDetailId = orderDetailId;
            this.CommodityId = commodityId;
            this.Count = count;
            this.Discount = Discount;
        }

        public OrderDetail(Commodity commodity, int count, float discount=1F)
        {
            this.Commodity = commodity;
            this.Count = count;
            this.Discount = discount;
        }

        public override string ToString()
        {
            return $"{Commodity}\tCount: {Count}\tDiscount: {Discount}\tMoney: {Math.Round(Money, 2)}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is OrderDetail orderDetail) || orderDetail.Commodity != this.Commodity
                || orderDetail.Count != this.Count || orderDetail.Discount != this.Discount)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return Commodity.GetHashCode() + Count + Convert.ToInt32(Discount * 100);
        }
    }
}
