using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch01_1_2
{
    public partial class CalculatorForm : Form
    {
        private string[] operators = { "+", "-", "*", "/" };

        public CalculatorForm()
        {
            InitializeComponent();

            /* 添加ComboBox选项 */
            operatorComboBox.Items.AddRange(operators);
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(num1TextBox.Text);
            int num2 = Convert.ToInt32(num2TextBox.Text);

            switch(operatorComboBox.SelectedItem)
            {
                case "+":
                    resultTextBox.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    resultTextBox.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    resultTextBox.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    resultTextBox.Text = (num1 / num2).ToString();
                    break;
                default:
                    break;
            }

        }
    }
}
