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
    public partial class LendingRates : Form
    {
        public LendingRates()
        {
            InitializeComponent();
        }
        double rateM = 0;
      
        double monPR = 0;
        //Power=次方
        double power = 0;
        double xxx = 0;

        //        試算公式：

        //每月應付利息金額＝本金餘額×月利率
        //每月應還本金金額＝平均每月應攤付本息金額－每月應付利息金額
        //=============================================
        //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率
        //    }÷{[(1＋月利率)^月數]－1}
        //(公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12)
        //每月應攤還本金與利息試算：
        //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 ＝每月應還本金金額＋每月應付利息金額

        StaticMenu SM = new StaticMenu();
        public void btnMonthlyPay_Click(object sender, EventArgs e)
        {    
           StaticMenu.loanA = Convert.ToDouble(txtLoanAmount.Text);
            StaticMenu.loanPYear = Convert.ToDouble(txtLoanPeriod.Text);
            StaticMenu.rate = Convert.ToDouble(txtRate.Text);
            StaticMenu.downP = Convert.ToDouble(txtDownPayment.Text);
            rateM = StaticMenu.rate / 12 / 100;
            xxx = 1 + rateM;
            //次方的方法
            power = Math.Pow(xxx, StaticMenu.loanPYear *12);
            monPR = (power* rateM) / ((power) - 1);
            StaticMenu.monP = (StaticMenu.loanA - StaticMenu.downP) * monPR;
            StaticMenu.monP =Math.Round(StaticMenu.monP, 2);
            MessageBox.Show ( "月付額:" + Convert.ToInt32(StaticMenu.monP) + "元");

        }

        public void btnTotalPay_Click(object sender, EventArgs e)
        {
            StaticMenu.loanA = Convert.ToDouble(txtLoanAmount.Text);
            StaticMenu.loanPYear = Convert.ToDouble(txtLoanPeriod.Text);
            StaticMenu.rate = Convert.ToDouble(txtRate.Text);
            StaticMenu.downP = Convert.ToDouble(txtDownPayment.Text);
            rateM = StaticMenu.rate / 12 / 100;
            xxx = 1 + rateM;
            power = Math.Pow(xxx, StaticMenu.loanPYear * 12);
            monPR = (power * rateM) / ((power) - 1);
            StaticMenu.monP = (StaticMenu.loanA - StaticMenu.downP) * monPR;
            StaticMenu.totalP = StaticMenu.monP * 12* StaticMenu.loanPYear;
            //避免按完Totalpay後直接report產生的小數點
            StaticMenu.monP = Math.Round(StaticMenu.monP, 2);
            //Math.Round取小數點的方法
            StaticMenu.totalP = Math.Round(StaticMenu.totalP, 2);
            MessageBox.Show("總付款金額:" + Convert.ToInt32(StaticMenu.totalP) + "元");
        }

        public void btnReport_Click(object sender, EventArgs e)
        {
            LRateRPform reportForm = new LRateRPform();
                reportForm.Show();
           reportForm. reportFormMethod();
        }
        

    }
}
