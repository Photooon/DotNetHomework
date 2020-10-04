using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAppForms
{
    public partial class OrderForm : Form
    {
        public Order OldOrder { get; set; }     // 如果是修改订单，则此项不为空
        public Order NewOrder { get; set; }     // 最后产生的订单
        public List<OrderDetailGrid> ShowingDetailGrids { get; set; }
        public OrderService OS { get; set; }    // 由父窗口传入，提供服务

        public OrderForm(OrderService OS, Order oldOrder=null)
        {
            this.OS = OS;
            this.OldOrder = oldOrder;
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            if (OldOrder != null)
            {
                IdTextBox.Text = OldOrder.Id.ToString();
                cusNameTextBox.Text = OldOrder.Customer.Name;
                cusAgeTextBox.Text = OldOrder.Customer.Age.ToString();

                ShowingDetailGrids = TransUtil.TransFromOrderDetails(OldOrder.OrderDetails);
            }
            else
            {
                IdTextBox.Text = OS.GetNextId().ToString();

                ShowingDetailGrids = new List<OrderDetailGrid>();
            }

            detailGridBindingSource.DataSource = ShowingDetailGrids;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            // 从各个控件和ShowingDetailGrids中重新构造出一个Order并塞入属性作为返回
            Customer customer = new Customer
            {
                Name = cusNameTextBox.Text,
                Age = Convert.ToInt32(cusAgeTextBox.Text)
            };

            NewOrder = new Order
            {
                Id = Convert.ToInt32(IdTextBox.Text),
                Customer = customer
            };

            
            var showingDetails = TransUtil.TransFromOrderDetailGrids(ShowingDetailGrids);    // 反向构造
            foreach (var detail in showingDetails)      // 由于之前为了避免两个重复的订单明细，所以把订单明细对外封装了，只能逐个加入
            {
                NewOrder.AddOrderDetail(detail);
            }

            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            NewOrder = null;
            Close();
        }
    }
}
