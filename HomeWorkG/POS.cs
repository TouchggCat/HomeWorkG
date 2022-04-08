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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
            txtTotalprice.Text = "NT$0";
        }
        string a1, a2, a3, a14;


        int a = 0;

        private void Apple1_Click(object sender, EventArgs e)
        {
            int i = 0;
            i += 1;
            a += 1;
            StaticMenu.menuPrice += i * 50;
            StaticMenu.apple1Price += i * 50;
            txtTotalprice.Text = "NT$" + StaticMenu.menuPrice;
            a1 = "頻果1號 X" + a + ",共NT$" + StaticMenu.apple1Price + "元 \n";
            txtList.Text = a1 + a2 + a3 + a14;
        }


        int b = 0;
        private void Apple2_Click(object sender, EventArgs e)
        {
            int i = 0;
             i += 1;
            b += 1;
            StaticMenu.menuPrice += i*200;
            StaticMenu.apple2Price += i * 200;
            txtTotalprice.Text = "NT$" + StaticMenu.menuPrice;
            a2= "頻果2號 X" + b + ",共NT$" + StaticMenu.apple2Price + "元\n";
            txtList.Text = a1 + a2 + a3 + a14;
        }

        int c = 0;
        private void Apple3_Click(object sender, EventArgs e)
        {
            int i = 0;
            i += 1;
            c += 1;
            StaticMenu.menuPrice += i*1000;
            StaticMenu.apple3Price += i * 1000;
            txtTotalprice.Text = "NT$" + StaticMenu.menuPrice;
            a3 = "頻果3號 X" + c+ ",共NT$" + StaticMenu.apple3Price + "元\n";
            txtList.Text = a1  + a2 +a3 +a14;
        }

        int d = 0;
        private void Apple14_Click(object sender, EventArgs e)
        {
            int i = 0;
            i += 1;
            d += 1;
            StaticMenu.menuPrice += i*30500;
            StaticMenu.apple14Price += i * 30500;
            txtTotalprice.Text = "NT$" + StaticMenu.menuPrice;
            a14 = "iPhone14 X" + d + ",共NT$" + StaticMenu.apple14Price + "元";
            txtList.Text = a1 + a2 + a3 + a14;
        }
        //====================================================
        private void btnCash_Click(object sender, EventArgs e)
        {
            int TTTT;
            TTTT = StaticMenu.menuPrice;
            if (TTTT == 0)
            {
                MessageBox.Show("尚未點餐!");
            }
            else
            {
                DialogResult result = MessageBox.Show("總金額: " + txtTotalprice.Text, "確認付款", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("確認");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("取消");
                        break;
                }
            }
        }
      
        private void btnCard_Click(object sender, EventArgs e)
        {
            int TTTT;
            TTTT = StaticMenu.menuPrice;
            if (TTTT == 0)
            {
                MessageBox.Show("尚未點餐!");
            }
            else
            {
                DialogResult result = MessageBox.Show("總金額: " + TTTT * 0.9, "確認付款", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("確認");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("取消");
                        break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
   
            StaticMenu.menuPrice = 0;
            StaticMenu.apple1Price = 0;
            StaticMenu.apple2Price = 0;
            StaticMenu.apple3Price = 0;
            StaticMenu.apple14Price =0;
            txtTotalprice.Text = "NT$0";
            txtList.Text = "";
            a1 = a2 = a3 = a14 = "";
            a = b = c = d = 0;
        }
    }
}
