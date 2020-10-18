using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace OrderApp
{
    public class OrderService
    {
        private readonly OrderContext orderContext;

        public OrderService(OrderContext orderContext)
        {
            this.orderContext = orderContext;       // 将Context作为参数，让框架注入
        }

        public void AddOrder(Order newOrder)
        {
            orderContext.Orders.Add(newOrder);
            orderContext.SaveChanges();
        }

        public void AddCommodity(Commodity commodity)
        {
            orderContext.Commodities.Add(commodity);
            orderContext.SaveChanges();
        }

        public void AddCustomer(Customer customer)
        {
            orderContext.Customers.Add(customer);
            orderContext.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = orderContext.Orders.FirstOrDefault(o => o.OrderId == id);
            orderContext.Orders.Remove(order);
            orderContext.OrderDetails.RemoveRange(order.OrderDetails);
            orderContext.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            DeleteOrder(order.OrderId);         // 删除原有的
            AddOrder(order);
        }

        public Order SearchWithId(int id)
        {
            return IntegratedOrders().SingleOrDefault(o => o.OrderId == id);
        }

        public IEnumerable<Order> SearchWithCommodityName(string name)
        {
            var q = IntegratedOrders().Where(o => o.OrderDetails.Count(od => od.Commodity.Name == name) != 0);
            return q.ToList();
        }

        public IEnumerable<Order> SearchWithCustomerName(String name)
        {
            var q = IntegratedOrders().Where(o => o.Customer.Name == name);
            return q.ToList();
        }

        public IEnumerable<Order> SearchWithMoney(double lower)
        {
            var q = IntegratedOrders().ToList().Where(o => o.Money > lower);    // 此处不先转为List，会产生顶级投影无法翻译的异常
            return q;
        }

        public IEnumerable<Order> SelectAll()
        {
            return IntegratedOrders().ToList();
        }

        private IQueryable<Order> IntegratedOrders()        // 返回完整的Order类（包含OrderDetail类和Customer类）
        {
            return orderContext.Orders.Include("OrderDetails").Include("OrderDetails.Commodity").Include("Customer");
        }
    }
}
