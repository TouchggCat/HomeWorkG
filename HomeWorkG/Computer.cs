using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkG
{
    public partial class Computer : Form
    {
        public Computer()
        {
            InitializeComponent();
            txtA.Text = "0";
        }
        double num1, num2, ans;


        private void btnP_Click(object sender, EventArgs e)
        {
            double test1, test2 = 0;

            bool aa = double.TryParse(txtN1.Text, out test1);
            bool bb = double.TryParse(txtN2.Text, out test2);
            if (aa && bb)
            {
                num1 = Convert.ToDouble(txtN1.Text);
                num2 = Convert.ToDouble(txtN2.Text);
                //ans = Convert.ToInt32(txtA.Text);
                //多餘的，且不需要從txtA輸入資料
                ans = num1 + num2;
                txtA.Text = "" + ans;
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式");
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            double test1, test2 = 0;
            bool aa = double.TryParse(txtN1.Text, out test1);
            bool bb = double.TryParse(txtN2.Text, out test2);
            if (aa && bb)
            {
                num1 = Convert.ToDouble(txtN1.Text);
                num2 = Convert.ToDouble(txtN2.Text);
                ans = num1 - num2;
                txtA.Text = "" + ans;
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式");
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            double test1, test2 = 0;
            bool aa = double.TryParse(txtN1.Text, out test1);
            bool bb = double.TryParse(txtN2.Text, out test2);
            if (aa && bb)
            {
                num1 = Convert.ToDouble(txtN1.Text);
                num2 = Convert.ToDouble(txtN2.Text);
                ans = num1 * num2;
                txtA.Text = "" + ans;
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式");
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            double test1, test2 = 0;
            bool aa = double.TryParse(txtN1.Text, out test1);
            bool bb = double.TryParse(txtN2.Text, out test2);
            if (aa && bb)
            {
                num1 = Convert.ToDouble(txtN1.Text);
                num2 = Convert.ToDouble(txtN2.Text);
                ans = num1 / num2;
                txtA.Text = "" + ans;
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            num1 = num2 = 0;
            txtN1.Text = txtN2.Text ="";
            txtA.Text = "0";
        }


    }
}
