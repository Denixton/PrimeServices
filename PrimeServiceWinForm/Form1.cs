using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimeServices;

namespace PrimeServiceWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tbNum.Text);

            PrimeService pm = new PrimeService();
            if (pm.IsPrime(a))
            {
                label2.Visible = true;
                label2.Text = "Да";
            }
            else
            {
                label2.Visible = true;
                label2.Text = "Нет";
            }  
        }

        private void tbNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                MessageBox.Show("Для ввода доступны только целые положительные числа");
            }
        }
    }
}
