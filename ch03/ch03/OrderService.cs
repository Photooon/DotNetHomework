using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ch03
{
    public class OrderService
    {
        private List<Order> orders;

        public OrderService()
        {
            orders = new List<Order>();
        }

        public void AddOrder(Order newOrder)
        {
            foreach (var o in this.orders)
            {
                if (newOrder.Id == o.Id)
                {
                    throw new Exception("订单添加错误，已存在相同订单号的订单");
                }
            }
            orders.Add(newOrder);
        }

        public void DeleteOrder(int id)
        {
            int i;
            bool existFlag = false;
            for (i = 0; i < orders.Count; i++)
            {
                if (orders[i].Id == id)
                {
                    orders.RemoveAt(i);     // 删除对应id的订单
                    existFlag = true;       // 对应id的订单存在
                    break;
                }
            }
            if (!existFlag)
            {
                throw new ArgumentException("订单删除错误，不存在指定Id的订单");
            }
        }

        public void ModifyOrder(Order order)
        {
            int i;
            for (i = 0; i < orders.Count; i++)
            {
                if (orders[i].Id == order.Id)
                {
                    orders[i] = order;      // 替换掉原来的订单
                    break;
                }
            }
            if (i == orders.Count)
            {
                throw new ArgumentException("订单修改错误，不存在指定的订单");
            }
        }

        public IEnumerable<Order> SearchWithId(int Id)
        {
            var q = from o in orders
                    where o.Id == Id
                    orderby o.Money descending
                    select o;
            return q;
        }

        public IEnumerable<Order> SearchWithName(string Name)
        {
            var q = orders.Where(
                o =>
                {
                    return o.OrderDetails.Where(
                        od =>
                        {
                            return od.Commodity.Name == Name;
                        }).Count() != 0;
                }).OrderByDescending(o => o.Money);          // 两层查询，当订单中有包含该名称的订单明细时，返回订单
            return q;
        }

        public IEnumerable<Order> SearchWithCustomer(Customer customer)
        {
            var q = from o in orders
                    where o.Customer.Equals(customer)
                    orderby o.Money descending
                    select o;
            return q;
        }

        public IEnumerable<Order> SearchWithMoney(double lower, double upper)
        {
            var q = from o in orders
                    where o.Money >= lower && o.Money <= upper
                    orderby o.Money descending
                    select o;
            return q;
        }

        public IEnumerable<Order> SearchWithMoney(double Money)
        {
            var q = from o in orders
                    where Math.Round(o.Money, 2) == Math.Round(Money, 2)    // 避免浮点数精确度的问题
                    orderby o.Money descending
                    select o;
            return q;
        }

        public IEnumerable<Order> SelectAll()
        {
            return orders;
        }

        public void Sort()
        {
            orders.Sort();
        }

        public void Sort(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }

        public void Export(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }
    }
}
