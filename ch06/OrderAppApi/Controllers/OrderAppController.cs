using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderApp;

namespace OrderAppApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderAppController : ControllerBase
    {
        private readonly OrderService os;

        public OrderAppController(OrderService os)
        {
            this.os = os;       // 在构造函数中增加OrderService参数，使之自动注入
        }

        /*查*/

        // GET: api/orderapp/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderWithId(int id)
        {
            return os.SearchWithId(id);
        }

        // GET: api/todo/{id}  id为路径参数
        [HttpGet("order/CommodityQuery")]
        public ActionResult<List<Order>> GetOrderWithCommodityName(string name)
        {
            return os.SearchWithCommodityName(name).ToList();
        }

        [HttpGet("order/CustomerQuery")]
        public ActionResult<List<Order>> GetOrderWithCustomerName(string name)
        {
            return os.SearchWithCustomerName(name).ToList();
        }

        [HttpGet("order/MoneyQuery")]
        public ActionResult<List<Order>> GetOrderWithMoney(int lower)
        {
            return os.SearchWithMoney(lower).ToList();
        }

        /*增*/

        // 增加货物
        [HttpPost("commodity")]
        public ActionResult<Commodity> PostCommodity(Commodity commodity)
        {
            try
            {
                os.AddCommodity(commodity);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return commodity;
        }

        // 增加顾客
        [HttpPost("customer")]
        public ActionResult<Customer> PostCustomer(Customer customer)
        {
            try
            {
                os.AddCustomer(customer);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return customer;
        }

        // 增加订单
        [HttpPost("Order")]
        public ActionResult<Order> PostOrder(MiddleOrder middleOrder)
        {
            Order order = middleOrder.Trans2Order();
            try
            {
                os.AddOrder(order);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return Content("Succeed");
        }

        /*删*/
        // DELETE: api/todo/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            try
            {
                os.DeleteOrder(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Content("Succeed");
        }

        /*改*/
        // PUT: api/todo/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> PutTodoItem(MiddleOrder middleOrder)
        {
            Order order = middleOrder.Trans2Order();
            try
            {
                os.UpdateOrder(order);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return Content("Succeed");
        }
    }
}
