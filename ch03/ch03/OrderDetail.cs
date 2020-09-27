using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03
{
    [Serializable]
    public class OrderDetail
    {
        public Commodity Commodity { get; set; }
        public int Count { get; set; }
        public float Discount { get; set; }

        public double Money
        {
            get
            {
                return Commodity.Price * Count * Discount;
            }
        }

        public OrderDetail()
        {
            this.Commodity = new Commodity();
            this.Count = 0;
            this.Discount = 1F;
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
