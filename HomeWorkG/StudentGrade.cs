using System;
using System.Collections;
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
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
        }
        //可能要用陣列寫嗎?
        //    先去寫陣列



        //使用ArrayList傳統集合
        ArrayList al = new ArrayList();
        private void btnAddS_Click(object sender, EventArgs e)
        {
            //把包含名字在內的所有數值都加入集合裡

            //string min = "";
            Myscore ms;
            ms.name = txtName.Text;
            ms.chinese = Convert.ToInt32(txtChinese.Text);
            ms.english= Convert.ToInt32(txtEnglish.Text);
            ms.math= Convert.ToInt32(txtMath.Text);
            ms.totalS = ms.chinese + ms.english + ms.math;
            ms.avgS = (ms.chinese + ms.english + ms.math) / 3;

            string max = "";
            string min = "";
            txtMain.Text = "姓名    國文    英文    數學     總分    平均    最低    最高\n";
            //等號設定同分時判斷以哪科為最高(國>英>數)
            if (ms.chinese >= ms.english && ms.chinese >= ms.math)
            {
                max = "國文" + ms.chinese;
            }
            if (ms.english > ms.chinese && ms.english >= ms.math)
            {
                max = "英文" + ms.english;
            }
            else if (ms.math > ms.chinese && ms.math > ms.english)
            {
                max = "數學" + ms.math;
            }
            ms.maxmax = max;
            if (ms.chinese <=ms.english&&ms.chinese<=ms.math)
            {
                min = "國文" + ms.chinese;
            }
            if(ms.english<ms.chinese&&ms.english<=ms.math)
            {
                min =  "英文" + ms.english;
            }
            else if(ms.math< ms.chinese&&ms.math<ms.english)
            {
                min= "數學" + ms.math;
            }
            ms.minmin = min;
            //把所有元素加入ArrayList
            al.Add(ms); //// boxing object
            showScore();  ////執行unboxing方法
            btnStat.Enabled = true;
        }

        int h = 0;
        string max = "";
        string min = "";
        public void btnRan_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            Myscore ms;
            //隨機姓名的編號
            h++;
            ms.name = Convert.ToString(h);

            ms.chinese = rng.Next(0, 100);
            ms.english = rng.Next(0, 100);
            ms.math = rng.Next(0, 100);
            

            ms.totalS = ms.chinese + ms.english + ms.math;
            ms.avgS = (ms.chinese + ms.english + ms.math) / 3;
            txtMain.Text = "姓名    國文    英文    數學     總分    平均      最低       最高\n";

            if (ms.chinese >= ms.english && ms.chinese >= ms.math)
            {
                max = "國文" + ms.chinese;
            }
            if (ms.english > ms.chinese && ms.english >= ms.math)
            {
                max = "英文" + ms.english;
            }
            else if (ms.math > ms.chinese && ms.math > ms.english)
            {
                max = "數學" + ms.math;
            }
            ms.maxmax = max;
            if (ms.chinese <= ms.english && ms.chinese <= ms.math)
            {
                min = "國文" + ms.chinese;
            }
            if (ms.english < ms.chinese && ms.english <= ms.math)
            {
                min = "英文" + ms.english;
            }
            else if (ms.math < ms.chinese && ms.math < ms.english)
            {
                min = "數學" + ms.math;
            }
            ms.minmin = min;
            al.Add(ms);
            showScore();
            btnStat.Enabled = true;
            btnReset.Enabled = true;
        }

        void showScore()
        {
            for (int i = 0; i < al.Count; i++)
            {
                // unboxing
                //對齊   OOO.PadRight(9)    等同於string.Format方法    OOO,-9
                //靠左對齊，不足字串9的部分往右補足剩下的空白
                txtMain.Text += $"{((Myscore)al[i]).name.PadRight(9)}{((Myscore)al[i]).chinese,-8}{((Myscore)al[i]).english,-8}{((Myscore)al[i]).math,-9}{((Myscore)al[i]).totalS,-8}{((Myscore)al[i]).avgS,-8}{((Myscore)al[i]).minmin,-9}{((Myscore)al[i]).maxmax,-8}  \n";
            }
        }






        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMain.Text = "姓名    國文    英文    數學     總分    平均    最低    最高\n";
            txtStat.Text = "";
            h = 0;
            //ArrayList清空
            al.Clear();
            btnStat.Enabled = false;
            btnReset.Enabled = false;
        }

       public void btnStat_Click(object sender, EventArgs e)
        {
            int ch = 0,en=0,ma=0;
            int mc = 0, me = 0, mm = 0;

            int[] arrch = new int[al.Count];
            int[] arren = new int[al.Count];
            int[] arrma = new int[al.Count];

            for (int i = 0; i < al.Count; i++)
            {
                ch += ((Myscore)al[i]).chinese;
                en+= ((Myscore)al[i]).english;
                ma+= ((Myscore)al[i]).math;
                mc += ((Myscore)al[i]).chinese/al.Count;
                me += ((Myscore)al[i]).english / al.Count;
                mm +=((Myscore)al[i]).math / al.Count;
                //把ArrayList轉換成陣列後輸出Max()/min()
                arrch[i]= ((Myscore)al[i]).chinese;
                arren[i] = ((Myscore)al[i]).english;
                arrma[i] = ((Myscore)al[i]).math;

                txtStat.Text = $"總分 {ch,7}{en,8}{ma,8}\n平均{mc,7}{me,8}{mm,8}\n最高分{arrch.Max(),5}{arren.Max(),8}{arrma.Max(),8}\n最低分{arrch.Min(),5}{arren.Min(),8}{arrma.Min(),8}";
                btnReset.Enabled = true;
            }
     
        }

        private void btnR20_Click(object sender, EventArgs e)
        {
         //執行多次Button方法的方法
            for(int i=0;i<20;i++)
            {
                btnRan_Click(null,null);
            }
        }
    }
}
