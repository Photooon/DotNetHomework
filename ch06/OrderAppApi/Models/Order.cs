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
    public class Order : IComparable
    {
        [Key, Column(Order = 1)]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        public double Money
        {
            get
            {
                double sum = 0;
                foreach (var o in OrderDetails)
                {
                    sum += o.Money;
                }
                return Math.Round(sum, 2);
            }
        }
        
        // 一对一映射
        public Customer Customer { get; set; }

        // 一对多映射
        public List<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            this.OrderDetails = new List<OrderDetail>();
        }

        public override string ToString()
        {
            string str = $"ID: {OrderId}\n" +
                $"Customer: \n\t{Customer}\n" +
                $"Money: {Math.Round(Money, 2)}\n" +
                $"Order Detail:\n";
            foreach (var orderDetail in OrderDetails)
            {
                str += "\t" + orderDetail.ToString() + "\n";
            }
            return str;
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Order order) || this.OrderId != order.OrderId) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return this.OrderId;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Order order))
            {
                throw new System.ArgumentException("CompareTo无法将object转为Order类型");
            }
            return this.OrderId - order.OrderId;
        }
    }
}
