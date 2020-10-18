using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApp {
    public sealed class MiddleOrder               // 为了便于POST添加订单，创建一个专门用于作POST上来的数据与Order实体类中间层的Model
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public List<MiddleOrderDetail> OrderDetails { get; set; }

        public Order Trans2Order()        // 转为Order实体类
        {
            Order o = new Order();
            o.OrderId = OrderId;
            o.CustomerId = CustomerId;
            o.OrderDetails = new List<OrderDetail>();
            foreach (var d in OrderDetails)
            {
                OrderDetail od = new OrderDetail(d.OrderDetailId, d.CommodityId, d.Count, d.Discount);
                o.OrderDetails.Add(od);
            }
            return o;
        }
    }

    public sealed class MiddleOrderDetail
    {
        public int OrderDetailId { get; set; }
        public int CommodityId { get; set; }
        public int Count { get; set; }
        public float Discount { get; set; }
    }
}
