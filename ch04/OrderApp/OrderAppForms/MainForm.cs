using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderAppForms
{
    public partial class MainForm : Form
    {
        private OrderService OS { get; set; }
        private List<OrderGrid> ShowingOrderGrids { get; set; }           // 正在显示的OrderGrid

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoaded(object sender, EventArgs e)
        {
            /*构造数据*/
            OS = new OrderService();
            Commodity basketball = new Commodity("Basketball", 62);
            Commodity bible = new Commodity("Bible", 25);
            Commodity tea = new Commodity("Tea", 28);
            Commodity iPad = new Commodity("iPad", 1000);

            Customer james = new Customer("James", 40);
            Customer underwood = new Customer("Underwood", 61);
            Customer tim = new Customer("Tim", 19);

            OrderDetail od1 = new OrderDetail(basketball, 5, 0.9F);
            OrderDetail od2 = new OrderDetail(bible, 1);
            OrderDetail od3 = new OrderDetail(tea, 6);
            OrderDetail od4 = new OrderDetail(iPad, 1, 0.75F);

            Order order1 = new Order();
            Order order2 = new Order();
            order1.Id = OS.GetNextId();
            order1.Customer = james;
            order1.AddOrderDetail(od1);
            order1.AddOrderDetail(od2);
            order1.AddOrderDetail(od3);
            order2.Id = OS.GetNextId();
            order2.Customer = underwood;
            order2.AddOrderDetail(od4);

            OS.AddOrder(order1);
            OS.AddOrder(order2);

            /*绑定数据*/
            ShowingOrderGrids = TransUtil.TransFromOrders(OS.SelectAll());
            orderBindingSource.DataSource = ShowingOrderGrids;
            detailBindingSource.DataSource = ShowingOrderGrids;
            detailBindingSource.DataMember = "OrderDetailGrids";        // 主从绑定
        }

        private void UpdateDataBinding(IEnumerable<Order> orders)        // 更新数据源
        {
            ShowingOrderGrids = TransUtil.TransFromOrders(orders);
            orderBindingSource.DataSource = ShowingOrderGrids;
            detailBindingSource.DataSource = ShowingOrderGrids;
        }

        private void OrderGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = orderDataGridView.CurrentCell.RowIndex;
            detailBindingSource.DataSource = ShowingOrderGrids[selectedRowIndex];
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(OS);
            orderForm.Text = "Add Order";
            orderForm.ShowDialog();
            if (orderForm.NewOrder != null)
            {
                OS.AddOrder(orderForm.NewOrder);
            }
            UpdateDataBinding(OS.SelectAll());
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = orderDataGridView.CurrentCell.RowIndex;
            OrderGrid selectedOrderGrid = ShowingOrderGrids[selectedRowIndex];
            OS.DeleteOrder(selectedOrderGrid.Id);
            UpdateDataBinding(OS.SelectAll());
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = orderDataGridView.CurrentCell.RowIndex;
            OrderGrid selectedOrderGrid = ShowingOrderGrids[selectedRowIndex];
            int selectedId = selectedOrderGrid.Id;      // 获取要修改的对象

            OrderForm orderForm = new OrderForm(OS, OS.SearchWithId(selectedId));
            orderForm.Text = "Update Order";
            orderForm.ShowDialog();
            if (orderForm.NewOrder != null)
            {
                OS.UpdateOrder(orderForm.NewOrder);
            }
            UpdateDataBinding(OS.SelectAll());
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(OS);
            searchForm.ShowDialog();        // 以阻塞的方式显示
            UpdateDataBinding(searchForm.SearchedOrders);
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            string path = folderBrowserDialog.SelectedPath + "\\orders.xml";

            try
            {
                OS.Export(path);
            }
            catch (Exception)
            {
                MessageBox.Show("文件路径不存在！");
            }
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "XML文档|*.xml";
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;

            try
            {
                OS.Import(path);
                UpdateDataBinding(OS.SelectAll());
            }
            catch (Exception)
            {
                MessageBox.Show("文件不存在或类型错误！");
            }
        }
    }
}
