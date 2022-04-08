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
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
        }

        //先驗證數字後進行計算餘數判斷
        private void btnOddEven_Click(object sender, EventArgs e)
        {
            int test1 = 0;
            bool aa = int.TryParse(txtNum.Text, out test1);
            if (aa)
            {
                int entNum;
                entNum = Convert.ToInt32(txtNum.Text);
                if (entNum % 2 == 0)
                {
                    labAnswer.Text = "數字:" + entNum + "是偶數";
                }
                else if (entNum % 2 == 1 || entNum % 2 == -1)
                {
                    labAnswer.Text = "數字:" + entNum + "是奇數";
                }
            }
            else
            {
                labAnswer.Text = "請輸入整數";
            }
        }
        // -----------------------------


        int[] Arr666 = { 7, 87, 993, 666, 7414, 69, 0 };
        //陣列要如何才不會受到方法裡影響(referencetype) 
        private void btnArrMaxMin_Click(object sender, EventArgs e)
        {
            //新建一個新陣列並指定長度作為目的地
            int[] gggg = new int[6];
            Array.Copy(Arr666, gggg, 6);
            //複製陣列Array.Copy(來源陣列,目標,複製長度)  ,有其他方法多載可指定複製起始位
            string result = "";
            for (int i = 0; i < Arr666.Length; i++)
            {
                result += Arr666[i] + "  ";
            }
            //先做迴圈求陣列再來找最大最小
            int Length;
            //照大小排順序
            Array.Sort(gggg);
            Length =gggg.Length;
            //長度-1 = 最後一個位置
            labAnswer.Text = "int陣列Arr666[" + result + "]" + "\n最大值:" + gggg[Length - 1] + "\n最小值:" + gggg[0];
        }


        private void btnArrOddEven_Click(object sender, EventArgs e)
        {
            int odd = 0, even = 0;
            string result = "";
            for (int i = 0; i < Arr666.Length; i++)
            {
                if(Arr666[i]%2==1)
                {
                    odd += 1;
                }
                else if (Arr666[i] % 2 == 0)
                {
                   even+= 1;
                }
                result += Arr666[i] + "  ";
            }
            labAnswer.Text = "int陣列Arr666[" + result + "]" + "\n奇數共" + odd + "個" + "\n偶數共" + even + "個";
        }


        private void btnSum_Click(object sender, EventArgs e)
        {
            int value=0;
            //value給初值0 , Text設定空字串來洗掉之前的內容
            labAnswer.Text = "";
            string result = "";
            for (int i = 0; i < Arr666.Length; i++)
            {
                value += Arr666[i];
                result += Arr666[i] + "  ";
            }
            labAnswer.Text = "int陣列Arr666[" + result + "]" + "\n加總為" + value;
        }

        //------------------------

        string[] ArrStr = { "一代一代一代", "奶酪", "太神啦", "你從桃園新竹X10", "爽阿刺阿" };

        private void btnArrLong_Click(object sender, EventArgs e)
        {
            // 使用ArrStr[i].length;
            {
                int x=0, y = 0;
                //Array.Sort(ArrStr);
                //int [i]strL = ArrStr[i];
                string result = "";
                //x起始值0,字串數比x大時會進入迴圈(第一圈>0必定會進入)
                //第二圈i=1,Length=2 > 6(x) 為false則不會進入迴圈，直到i=3
                for (int i = 0; i < ArrStr.Length; i++)
                {
                    if (ArrStr[i].Length > x)
                    {
                        x = ArrStr[i].Length;
                        y = i;
                    }
                    result += ArrStr[i] + " ";
                }
              // i被定義在for迴圈，而且要通過if，不能在for迴圈中回傳答案，不然會直接帶入最後一筆i
              // 結果要放for外面找個變數y接它
                labAnswer.Text = "int陣列ArrStr[" + result + "]" + "\n最長字串:" + ArrStr[y];
            }

        }
        string[] cCena = { "GoodMorning", "China" , "IceCream" ,"Ready123", "2weekslater", "TheFastAndTheFurious9", "JohnCena",  "AlmostSame" };
        //bool string.Contains("OOO") 回傳是否含有此OOO字串
        private void btnArrCc_Click(object sender, EventArgs e)
        {
            string result = "";
            int x = 0;
            for(int i=0; i<cCena.Length-1;i++)
            {
                if (cCena[i].Contains("C")||cCena[i].Contains("c"))
                {
                    x += 1;
                }
                result += cCena[i] + " , ";
            }
            //優化後的方式，長度帶入陣列中
            labAnswer.Text = "陣列cCena: [" + result + cCena[cCena.Length - 1] + "] \n有C及c的字串者有:" + x + "個";
            ////優化前尾端不留逗號的方式
            //for (int i = cCena.Length - 1; i == cCena.Length - 1; i++)
            //{
            //    if (cCena[i].Contains("C") || cCena[i].Contains("c"))
            //    {
            //        x += 1;
            //    }
            //    result += cCena[i];
            //}
            //labAnswer.Text = "陣列cCena: [" + result + "] \n有C及c的字串者有:" + x + "個";
        }

        //如何把BoolArr[i,r]的值排列換行??
        private void btn101010_Click(object sender, EventArgs e)
        {
            labAnswer.Text = "";
            //建立陣列並決定長度
            int[,] BoolArr = new int[10, 10];
            for (int i = 0; i < BoolArr.GetLength(0); i++)
            {
                //從i=0開始進入內層,一輪0~9後到外層換行
                for (int r = 0; r < BoolArr.GetLength(1); r++)
                {
                    //維度相加求餘數做出布林值的效果
                    if ((i + r) % 2 == 0)
                    {
                        BoolArr[i, r] = 1;
                    }
                    else if ((i + r) % 2 == 1)
                    {
                        BoolArr[i, r] = 0;
                    }
                    labAnswer.Text += BoolArr[i, r] + " ";
                }
                labAnswer.Text += "\n";
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            labAnswer.Text = "";
            //更改陣列大小可得到一樣效果
            //或是使用textbox更改大小
            int[,] edge1 = new int[10, 10];
            for (int i = 0; i < edge1.GetLength(0); i++)
            {
                for (int r = 0; r < edge1.GetLength(1); r++)
                {
                    if (i == 0)
                    {
                        edge1[i, r] = 1;
                    }
                    else if (r == 0)
                    {
                        edge1[i, r] = 1;
                    }
                    else if (i == edge1.GetLength(0) - 1)
                    {
                        edge1[i, r] = 1;
                    }
                    else if (r == edge1.GetLength(1) - 1)
                    {
                        edge1[i, r] = 1;
                    }
                    else
                    {
                        edge1[i, r] = 0;
                    }
                    labAnswer.Text += edge1[i, r] + "   ";
                }
                labAnswer.Text += "\n";
                //i每跑完一輪換行
            }
            //想法:邊1內0/邊0內1 最小值跟最大值的陣列組合
            //[0,i]=1 [i,0]=1,[i,Length-1]=1,[L-1,i]=1
            //仔細想一下變數帶入的情形
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            labAnswer.Text = "";
            int[,] edge1 = new int[10, 10];
            for (int i = 0; i < edge1.GetLength(0); i++)
            {
                for (int r = 0; r < edge1.GetLength(1); r++)
                {
                    if (i == 0)
                    {
                        edge1[i, r] = 0;
                    }
                    else if (r == 0)
                    {
                        edge1[i, r] = 0;
                    }
                    else if (i == edge1.GetLength(0) - 1)
                    {
                        edge1[i, r] = 0;
                    }
                    else if (r == edge1.GetLength(1) - 1)
                    {
                        edge1[i, r] = 0;
                    }
                    else
                    {
                        edge1[i, r] = 1;
                    }
                    labAnswer.Text += edge1[i, r] + "  ";
                }
                labAnswer.Text += "\n";
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            MessageBox.Show($"a:{a},b:{b}");
            Swap(ref a, ref b);
            //Swap( a,  b);
            MessageBox.Show($"a:{a},b:{b}");
        }
        //ref關鍵字只作用在方法的參數
        //不會對方法內運算有影響
        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        //void Swap( int A,  int B)
        //{
        //    int T = A;
        //    A = B;
        //    B = T;
        //}
    }
}

