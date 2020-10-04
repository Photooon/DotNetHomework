using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderApp
{
    public class OrderService
    {
        private int NextId;             // 创建订单时，从OrderService里获取一个新的订单号NextId
        private List<Order> orders;

        public OrderService()
        {
            NextId = 1;
            orders = new List<Order>();
        }

        public void AddOrder(Order newOrder)
        {
            if (orders.Contains(newOrder))      // 由于Order类实现了Equals方法，所以可以用Contain方法查询
            {
                throw new Exception("订单添加错误，已存在相同订单号的订单");
            }
            orders.Add(newOrder);
        }

        public void DeleteOrder(int id)
        {
            orders.RemoveAll(o => o.Id == id);
        }

        public void UpdateOrder(Order order)
        {
            DeleteOrder(order.Id);
            AddOrder(order);
        }

        public Order SearchWithId(int Id)
        {
            return orders.FirstOrDefault(o => o.Id == Id);
        }

        public IEnumerable<Order> SearchWithCommodityName(string Name)
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
            if (Path.GetExtension(path) != ".xml")
            {
                throw new ArgumentException($"{path} is not a xml file!");
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException($"{path} does not exist!");
            }

            if (Path.GetExtension(path) != ".xml")
            {
                throw new ArgumentException($"{path} is not a xml file!");
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }

        /*返回一个未使用的ID号*/
        public int GetNextId()
        {
            var IdCollection = from o in orders
                               select o.Id;

            while (IdCollection.Contains(NextId)) NextId++;     // 找出不重复的Id

            return NextId++;
        }
    }
}
