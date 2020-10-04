using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAppForms
{
    public partial class SearchForm : Form
    {
        public OrderService OS { get; set; }                        // 服务类，需要父窗口通过构造函数设置
        public IEnumerable<Order> SearchedOrders { get; set; }      // 搜索的结果，作为属性供父窗口获取

        public SearchForm(OrderService OS)
        {
            this.OS = OS;
            InitializeComponent();
        }

        private void IdConfirmButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")                           // 没有内容时判定为全部都展示
            {
                SearchedOrders = OS.SelectAll();
                Close();
                return;         // 这个地方不return时，框架会等方法执行完后才将窗口关闭
            }

            try
            {
                int Id = Convert.ToInt32(IdTextBox.Text);       // 没有使用数据绑定，因为直接读取即可，比较简单。
                SearchedOrders = new List<Order>
                {
                    OS.SearchWithId(Id)
                };
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("输入的ID无法转为数字！");
            }
        }

        private void ComConfirmButton_Click(object sender, EventArgs e)
        {
            if (comNameTextBox.Text == "")
            {
                SearchedOrders = OS.SelectAll();
                Close();
                return;
            }

            string commodityName = comNameTextBox.Text;
            SearchedOrders = OS.SearchWithCommodityName(commodityName);
            Close();
        }

        private void CusConfirmButton_Click(object sender, EventArgs e)
        {
            if (cusNameTextBox.Text == "" && cusAgeTextBox.Text == "")
            {
                SearchedOrders = OS.SelectAll();
                Close();
                return;
            }

            try
            {
                string name = cusNameTextBox.Text;
                int age = Convert.ToInt32(cusAgeTextBox.Text);
                Customer customer = new Customer
                {
                    Name = name,
                    Age = age
                };

                SearchedOrders = OS.SearchWithCustomer(customer);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("输入的顾客年龄无法转为数字！");
            } 
        }

        private void MoneyConfirmButton_Click(object sender, EventArgs e)
        {
            if (upperTextBox.Text == "" && lowerTextBox.Text == "")
            {
                SearchedOrders = OS.SelectAll();
                Close();
                return;
            }

            try
            {
                int upper = Convert.ToInt32(upperTextBox.Text);
                int lower = Convert.ToInt32(lowerTextBox.Text);
                SearchedOrders = OS.SearchWithMoney(lower, upper);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("输入的金额上下限无法转为数字！");
            }
        }
    }
}
