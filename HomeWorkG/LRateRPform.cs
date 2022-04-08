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
    public partial class LRateRPform : Form
    {
        public LRateRPform()
        {
            InitializeComponent();
        }


        public void reportFormMethod()
          {
            label6.Text = StaticMenu.loanA + "";
            label7.Text = StaticMenu.loanPYear + "";
            label8.Text = StaticMenu.rate + "";
            label9.Text = StaticMenu.downP + "";
            label10.Text = StaticMenu.totalP + "";
            label12.Text = StaticMenu.monP + "";
          }
    }
}
