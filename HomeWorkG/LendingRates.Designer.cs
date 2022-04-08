
namespace HomeWorkG
{
    partial class LendingRates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.btnMonthlyPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoanPeriod = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.btnTotalPay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(223, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(322, 64);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(100, 27);
            this.txtLoanAmount.TabIndex = 1;
            // 
            // btnMonthlyPay
            // 
            this.btnMonthlyPay.Location = new System.Drawing.Point(199, 357);
            this.btnMonthlyPay.Name = "btnMonthlyPay";
            this.btnMonthlyPay.Size = new System.Drawing.Size(84, 44);
            this.btnMonthlyPay.TabIndex = 2;
            this.btnMonthlyPay.Text = "月繳金額";
            this.btnMonthlyPay.UseVisualStyleBackColor = true;
            this.btnMonthlyPay.Click += new System.EventHandler(this.btnMonthlyPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(195, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "還款期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(241, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "利率%";
            // 
            // txtLoanPeriod
            // 
            this.txtLoanPeriod.Location = new System.Drawing.Point(322, 136);
            this.txtLoanPeriod.Name = "txtLoanPeriod";
            this.txtLoanPeriod.Size = new System.Drawing.Size(100, 27);
            this.txtLoanPeriod.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(322, 200);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 27);
            this.txtRate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(239, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "頭期款";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(322, 267);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(100, 27);
            this.txtDownPayment.TabIndex = 8;
            // 
            // btnTotalPay
            // 
            this.btnTotalPay.Location = new System.Drawing.Point(338, 357);
            this.btnTotalPay.Name = "btnTotalPay";
            this.btnTotalPay.Size = new System.Drawing.Size(84, 44);
            this.btnTotalPay.TabIndex = 9;
            this.btnTotalPay.Text = "總金額";
            this.btnTotalPay.UseVisualStyleBackColor = true;
            this.btnTotalPay.Click += new System.EventHandler(this.btnTotalPay_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(484, 357);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(84, 44);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // LendingRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 498);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPay);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtLoanPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMonthlyPay);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LendingRates";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Button btnMonthlyPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoanPeriod;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Button btnTotalPay;
        private System.Windows.Forms.Button btnReport;
    }
}