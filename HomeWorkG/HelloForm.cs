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
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Hight = txtHight.Text;
            MessageBox.Show("Hello!  我是" + Name + ",\n我的英文名字是" + EngName +
                ",\n我是" + comboSex.Text + ",\n我的身高" + Hight + "公分" + "\n我就爛!");
        }
    }
}
