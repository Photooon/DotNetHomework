using Microsoft.VisualStudio.TestTools.UnitTesting;
using ch03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ch03.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        private OrderService orderService = new OrderService();

        /*Commodities*/
        private static Commodity basketball = new Commodity("Basketball", 62);     // 为了便于CRUD，把这些变量作为类成员
        private static Commodity bible = new Commodity("Bible", 25);
        private static Commodity tea = new Commodity("Tea", 28);
        private static Commodity iPad = new Commodity("iPad", 1000);

        /*Customers*/
        private static Customer james = new Customer("James", 40);
        private static Customer underwood = new Customer("Underwood", 61);
        private static Customer tim = new Customer("Tim", 19);

        /*OrderDetails*/
        private static OrderDetail od1 = new OrderDetail(basketball, 5, 0.9F);
        private static OrderDetail od2 = new OrderDetail(bible, 1);
        private static OrderDetail od3 = new OrderDetail(tea, 6);
        private static OrderDetail od4 = new OrderDetail(iPad, 1, 0.75F);

        private Order order1 = new Order();
        private Order order2 = new Order();

        [TestInitialize]
        public void Init()
        {
            order1.Id = 1;
            order1.Customer = james;        // James对应Order1，有两条订单明细
            order1.AddOrderDetail(od1);     
            order1.AddOrderDetail(od2);

            order2.Id = 2;
            order2.Customer = underwood;    // Underwood对应Order2，有一条订单明细
            order2.AddOrderDetail(od3);

            orderService.AddOrder(order2);  // 这里反过来放入是为了后面排序便于验证
            orderService.AddOrder(order1);
        }

        [TestMethod()]
        public void AddCorrectOrderTest()
        {
            Order order = new Order         // 订单号不与已有订单重复，是正确的订单
            {
                Id = 3,
                Customer = tim
            };
            order.AddOrderDetail(od4);

            orderService.AddOrder(order);

            bool assertFlag = false;
            var orders = orderService.SelectAll();
            if (orders.Contains(order))
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void AddWrongOrderTest()
        {
            Order order = new Order         // 订单号与已有订单重复，是错误的订单
            {
                Id = 2,
                Customer = tim
            };
            order.AddOrderDetail(od4);

            bool assertFlag = false;
            try
            {
                orderService.AddOrder(order);
            }
            catch (Exception)               // 只有发生意外才是正确的
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void DeleteExistingOrderTest()
        {
            bool assertFlag = false;
            orderService.DeleteOrder(1);        // 删除order1

            var orders = orderService.SelectAll();
            if (!orders.Contains(order1))
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void DeleteInexistingOrderTest()
        {
            bool assertFlag = false;

            try
            {
                orderService.DeleteOrder(3);        // 删除order3，由于没有添加，会抛出异常
            }
            catch (Exception)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void ModifyExistingOrderTest()
        {
            bool assertFlag = false;

            james.Age = 41;
            Order order = orderService.SearchWithId(1).First();      //将订单找出来之后进行修改
            order.Customer = james;
            orderService.ModifyOrder(order);

            var orderNamedJames = orderService.SearchWithId(1);
            if (orderNamedJames.Count() != 0)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void ModifyInexistingOrderTest()
        {
            bool assertFlag = false;

            Order order = new Order         // 订单号与已有订单重复，是错误的订单
            {
                Id = 3,
                Customer = tim
            };
            order.AddOrderDetail(od4);

            try
            {
                orderService.ModifyOrder(order);       // 修改一个不存在的order
            }
            catch (Exception)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SearchWithIdTest()
        {
            bool assertFlag = false;

            var order1 = orderService.SearchWithId(1);
            var order2 = orderService.SearchWithId(2);
            
            if (order1.Count() != 0 && order2.Count() != 0)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SearchWithInexistingIdTest()
        {
            bool assertFlag = false;

            var order3 = orderService.SearchWithId(3);

            if (order3.Count() == 0)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SearchWithNameTest()
        {
            bool assertFlag = false;

            var order1 = orderService.SearchWithName(basketball.Name);
            var order2 = orderService.SearchWithName(tea.Name);

            if (order1.Count() != 0 && order2.Count() != 0)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SearchWithInexistingNameTest()
        {
            bool assertFlag = false;

            var order3 = orderService.SearchWithName(iPad.Name);

            if (order3.Count() == 0)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SearchWithCustomerTest()
        {
            bool assertFlag = false;

            var order1 = orderService.SearchWithCustomer(james);
            var order2 = orderService.SearchWithCustomer(underwood);

            if (order1.Count() != 0 && order2.Count() != 0)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SearchWithInexistingCustomerTest()
        {
            bool assertFlag = false;

            var order3 = orderService.SearchWithCustomer(tim);

            if (order3.Count() == 0)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SearchWithMoneyRangeTest()
        {
            bool assertFlag = false;
            double lower = od1.Money + od2.Money - 10;
            double upper = od1.Money + od2.Money + 10;

            var orders = orderService.SearchWithMoney(lower, upper);
            if (orders.Count() != 0)
            {
                assertFlag = true;
            }
            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SearchWithMoneyTest()
        {
            bool assertFlag = false;
            double money = od1.Money + od2.Money;

            var orders = orderService.SearchWithMoney(money);
            if (orders.Count() == 1)
            {
                assertFlag = true;
            }
            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SortTest()
        {
            bool assertFlag = true;

            Order order3 = new Order
            {
                Id = 3,
                Customer = tim
            };
            order3.AddOrderDetail(od4);
            orderService.AddOrder(order3);       // 此时order顺序为2、1、3

            orderService.Sort();
            var orders = orderService.SelectAll();
            int lastId = orders.First().Id;
            foreach (var order in orders)
            {
                if (order.Id < lastId)
                {
                    assertFlag = false;
                    break;
                }
                lastId = order.Id;
            }
            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void SortLambdaTest()
        {
            bool assertFlag = true;

            Order order3 = new Order
            {
                Id = 3,
                Customer = tim
            };
            order3.AddOrderDetail(od4);
            orderService.AddOrder(order3);

            orderService.Sort((o1, o2) => { return Convert.ToInt32(o1.Money - o2.Money); });    //按金额排序
            var orders = orderService.SelectAll();
            double lastMoney = orders.First().Money;
            foreach (var order in orders)
            {
                if (order.Money < lastMoney)
                {
                    assertFlag = false;
                    break;
                }
                lastMoney = order.Money;
            }
            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void ExportToCorrectPathTest()
        {
            bool assertFlag = false;

            try
            {
                orderService.Export("./orders.xml");
                assertFlag = true;
                File.Delete("./orders.xml");    // 用完删除，不影响下一次测试
            }
            catch (Exception) { }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void ImportFromCorrectPathTest()
        {
            bool assertFlag = false;

            orderService.Export("./orders.xml");    // 先导出再导入

            OrderService os = new OrderService();
            os.Import("./orders.xml");

            File.Delete("./orders.xml");

            var orders = os.SelectAll();
            if (orders.Count() != 0)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }

        [TestMethod()]
        public void ImportFromWrongPathTest()
        {
            bool assertFlag = false;

            OrderService os = new OrderService();

            try
            {
                os.Import("./non-orders.xml");
            }
            catch (Exception)
            {
                assertFlag = true;
            }

            Assert.IsTrue(assertFlag);
        }
    }
}
