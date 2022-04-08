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
    public partial class DoForWhile : Form
    {
        public DoForWhile()
        {
            InitializeComponent();
        }

        private void btn9x9_Click(object sender, EventArgs e)
        {
            int X = 0;
            string ninenine = "";
            for (int i= 1;i<10;i++)
            {
                for (int n = 1; n < 10; n++)
                {
                    if (i * n < 10)
                    {
                        //對齊用，答案<10的等於後多兩個空格
                        X = i * n;
                        ninenine += Convert.ToString(n) + " X " + Convert.ToString(i) + "=  " + X + " | ";
                    }
                    else
                    {
                        X = i * n;
                        ninenine += Convert.ToString(n) + " X " + Convert.ToString(i) + "=" + X + " | ";
                    }
                }
                ninenine += "\n";
            }
            labResult.Text = "九九乘法表\n" + ninenine;
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            int row = 0;
            if (int.TryParse(txtRows.Text, out row))
            {
                row = Convert.ToInt32(txtRows.Text);
                for (int i = 1; i < row + 1; i++)
                {
                    //可在指定位置插入字串i次
                    ////x += new StringBuilder("都可以").Insert(1, "◣", i).ToString() + "\n";
                    //x += new StringBuilder("都可以".Length ).Insert(0, "◣", i).ToString() + "\n";
                    //重複字串i次為下列方法(單邊/雙邊)
                    //x+= string.Concat(Enumerable.Repeat("◣", i)) + "\n";
                    labResult.Text += string.Concat(Enumerable.Repeat("    ", row - i)) + string.Concat(Enumerable.Repeat("◢", i)) + string.Concat(Enumerable.Repeat("◣", i)) + "\n";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnlottery_Click(object sender, EventArgs e)
        {
            string s = "";
            int[] pool = new int[49]; //將所有號碼(1~49)放入陣列pool中
            for (int i = 0; i < pool.Length; i++)
            {
                pool[i] = i + 1;

            }
            int[] x = new int[6]; //宣告要取多少個數字
            Random rng = new Random();
            for (int j = 0; j < x.Length; j++)
            {
                int temp = rng.Next(1, 49); //隨機抓取一組數字放入x[]陣列中
                if (pool[temp] == 0)
                {
                    j--;
                }
                //如果數字為0，則重新產生亂數
                else
                {
                    x[j] = pool[temp]; //否則將亂數產生之數字放入x[]陣列中
                    s += x[j].ToString() + ",";//每個數字以,分隔
                    //pool[temp] = 0; //將以使用之數字以零取代
                    labResult.Text = s.Substring(0, s.Length - 1);
                    //去除最後一個逗號
                }
            }
            
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            int SSS = 100;
            labResult.Text=Convert.ToString(SSS, 2);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int f = 0;
            int t = 0;
            int s = 0;
            int x = 0;
            int y = 0;
            int test1, test2, test3 = 0;
            bool aa = int.TryParse(txtFrom.Text, out test1);
            bool bb = int.TryParse(txtTo.Text, out test2);
            bool cc = int.TryParse(txtStep.Text, out test3);

            if (aa && bb && cc)
            {
                f = Convert.ToInt32(txtFrom.Text);
                t = Convert.ToInt32(txtTo.Text);
                s = Convert.ToInt32(txtStep.Text);
                //for的判斷式無法寫成x<t 因為x會先在迴圈裡面計算完，所以要在裡面加if判斷
                for (int i = 0; x < int.MaxValue; i++)
                {
                    x = f + i * s;
                    if (x <= t)
                    {
                        y += x;
                        labResult.Text = f + " 到 " + t + " 相隔 " + (s - 1) + "\n加總為: " + y;
                    }
                    else
                    {
                        break;
                        //避免x>t之後的無窮迴圈
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int f = 0;
            int t = 0;
            int s = 0;
            int x = 0;
            int y = 0;
            int test1, test2, test3 = 0;
            bool aa = int.TryParse(txtFrom.Text, out test1);
            bool bb = int.TryParse(txtTo.Text, out test2);
            bool cc = int.TryParse(txtStep.Text, out test3);

            if (aa && bb && cc)
            {
                f = Convert.ToInt32(txtFrom.Text);
                t = Convert.ToInt32(txtTo.Text);
                s = Convert.ToInt32(txtStep.Text);
                int i = 0;
                while ( x < int.MaxValue)
                {
                    x = f + i * s;
                    if (x <= t)
                    {
                        y += x;
                        labResult.Text = f + " 到 " + t + " 相隔 " + (s - 1) + "\n加總為: " + y;
                    }
                    else
                    {
                        break;
                    }
                    i++;
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void Do_Click(object sender, EventArgs e)
        {
            int f = 0;
            int t = 0;
            int s = 0;
            int x = 0;
            int y = 0;
            int test1, test2, test3 = 0;
            bool aa = int.TryParse(txtFrom.Text, out test1);
            bool bb = int.TryParse(txtTo.Text, out test2);
            bool cc = int.TryParse(txtStep.Text, out test3);

            if (aa && bb && cc)
            {
                f = Convert.ToInt32(txtFrom.Text);
                t = Convert.ToInt32(txtTo.Text);
                s = Convert.ToInt32(txtStep.Text);
                int i = 0;
                do
                {
                    x = f + i * s;
                    if (x <= t)
                    {
                        y += x;
                        labResult.Text = f + " 到 " + t + " 相隔 " + (s - 1) + "\n加總為: " + y;
                    }
                    else
                    {
                        break;
                    }
                    i++;
                } while (x < int.MaxValue);
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
