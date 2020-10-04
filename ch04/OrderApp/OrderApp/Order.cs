using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    [Serializable]
    public class Order : IComparable
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public double Money
        {
            get
            {
                double sum = 0;
                OrderDetails.ForEach(o => sum += o.Money);
                return Math.Round(sum, 2);
            }
        }

        private List<OrderDetail> orderDetails;     // 为了保证订单明细不重复，这里将orderDetails作为私有成员，并提供添加订单明细方法

        public List<OrderDetail> OrderDetails => orderDetails;

        public Order()
        {
            Random random = new Random();
            this.Id = random.Next(0, 10000);
            this.Customer = new Customer();
            this.orderDetails = new List<OrderDetail>();
        }

        public Order(int Id, Customer customer, List<OrderDetail> orderDetails)
        {
            this.Id = Id;
            this.Customer = customer;
            this.orderDetails = orderDetails;
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            foreach (var od in OrderDetails)
            {
                if (od.Equals(orderDetail))
                {
                    throw new Exception("添加OrderDetail错误，OrderDetail重复");
                }
            }
            OrderDetails.Add(orderDetail);
        }

        public override string ToString()
        {
            string str = $"ID: {Id}\n" +
                $"Customer: \n\t{Customer}\n" +
                $"Money: {Math.Round(Money, 2)}\n" +
                $"Order Detail:\n";
            foreach (var orderDetail in orderDetails)
            {
                str += "\t" + orderDetail.ToString() + "\n";
            }
            return str;
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Order order) || this.Id != order.Id) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Order order))
            {
                throw new System.ArgumentException("CompareTo无法将object转为Order类型");
            }
            return this.Id - order.Id;
        }
    }
}
