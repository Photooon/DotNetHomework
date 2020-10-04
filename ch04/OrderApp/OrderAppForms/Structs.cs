using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderApp;

namespace OrderAppForms
{
    public class OrderGrid
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int CustomerAge { get; set; }
        public double TotalPrice { get; set; }

        public List<OrderDetailGrid> OrderDetailGrids { get; set; }
    }

    public class OrderDetailGrid
    {
        public string CommodityName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public float Discount { get; set; }
        public double Sum { get; set; }
    }
    
    /// <summary>
    /// 将OrderService提供的实体类转为视图层可以显示的结构
    /// </summary>
    class TransUtil
    {
        public static List<OrderGrid> TransFromOrders(IEnumerable<Order> orders)
        {
            List<OrderGrid> orderTable = new List<OrderGrid>();

            foreach (Order order in orders)
            {
                if (order == null) break;       // 为空说明没有数据

                OrderGrid orderGrid = new OrderGrid()
                {
                    Id = order.Id,
                    CustomerName = order.Customer.Name,
                    CustomerAge = order.Customer.Age,
                    TotalPrice = order.Money
                };

                List<OrderDetailGrid> orderDetailGrids = TransFromOrderDetails(order.OrderDetails);
                orderGrid.OrderDetailGrids = orderDetailGrids;
                orderTable.Add(orderGrid);
            }

            return orderTable;
        }

        public static List<OrderDetailGrid> TransFromOrderDetails(IEnumerable<OrderDetail> orderDetails)
        {
            List<OrderDetailGrid> orderTable = new List<OrderDetailGrid>();

            foreach (OrderDetail od in orderDetails)
            {
                if (od == null) break;

                OrderDetailGrid orderDetailGrid = new OrderDetailGrid()
                {
                    CommodityName = od.Commodity.Name,
                    Price = od.Commodity.Price,
                    Count = od.Count,
                    Discount = od.Discount,
                    Sum = od.Money
                };
                orderTable.Add(orderDetailGrid);
            }

            return orderTable;
        }

        public static List<OrderDetail> TransFromOrderDetailGrids(List<OrderDetailGrid> orderDetailGrids)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            foreach (OrderDetailGrid detailGrid in orderDetailGrids)
            {
                if (detailGrid == null) break;

                Commodity commodity = new Commodity
                {
                    Name = detailGrid.CommodityName,
                    Price = detailGrid.Price
                };

                OrderDetail orderDetail = new OrderDetail
                {
                    Commodity = commodity,
                    Discount = detailGrid.Discount,
                    Count = detailGrid.Count
                };

                orderDetails.Add(orderDetail);
            }

            return orderDetails;
        }
    }
}
