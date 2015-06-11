using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(number1TextBox.Text);
            float number2 = float.Parse(number2TextBox.Text);
            float number3 = float.Parse(number3TextBox.Text);
            float number4 = float.Parse(number4TextBox.Text);
            float total1 = number1 + number2;
            float total2 = number3 + number4;
            float alltotal = total1 + total2;
            total1TextBox.Text = string.Format("{0}", total1);
            total2TextBox.Text = string.Format("{0}", total2);
            alltotalTextBox.Text = string.Format("{0}", alltotal);
        }
    }
}