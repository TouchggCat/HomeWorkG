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
    public partial class maxminiScores : Form
    {
        public maxminiScores()
        {
            InitializeComponent();
        }

        string result = "";
        string maxScore = "";
        string minScore = "";
        int num = 0;

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            result = textBox1.Text + textBox2.Text + textBox3.Text;
            if (int.TryParse(result, out num))
            {
                MessageBox.Show("成功儲存!");

                Myscore ms = new Myscore();
                ms.chinese = int.Parse(textBox1.Text);
                ms.english = int.Parse(textBox2.Text);
                ms.math = int.Parse(textBox3.Text);
                result = "姓名" + txtName.Text + "\n國文:" + ms.chinese + "\n英文:" + ms.english + "\n數學:" + ms.math;
            }
           else
           {
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            label1.Text = result;
        }

        private void btnMaxMini_Click(object sender, EventArgs e)
        {
            result = textBox1.Text + textBox2.Text + textBox3.Text;
            if (int.TryParse(result, out num))
            {
                Myscore ms = new Myscore();
                ms.chinese = int.Parse(textBox1.Text);
                ms.english = int.Parse(textBox2.Text);
                ms.math = int.Parse(textBox3.Text);

                if (ms.chinese > ms.english && ms.chinese > ms.math)
                {
                    maxScore = "最高分為國文:" + ms.chinese + "分";
                }
                else if (ms.english > ms.chinese && ms.english > ms.math)
                {
                    maxScore = "最高分為英文:" + ms.english + "分";
                }
                else if (ms.math > ms.chinese && ms.math > ms.english)
                {
                    maxScore = "最高分為數學:" + ms.math + "分";
                }
                if (ms.chinese > ms.math && ms.english > ms.math)
                {
                    minScore = "最低分為數學:" + ms.math + "分";
                }
                else if (ms.english < ms.chinese && ms.english < ms.math)
                {
                    minScore = "最低分為英文:" + ms.english + "分";
                }
                else if (ms.chinese < ms.english && ms.chinese < ms.math)
                {
                    minScore = "最低分為國文:" + ms.chinese + "分";
                }

                labMaxMin.Text = maxScore + "\n" + minScore;
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }

        }
    }
}
