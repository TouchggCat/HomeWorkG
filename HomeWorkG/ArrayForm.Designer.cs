
namespace HomeWorkG
{
    partial class ArrayForm
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOddEven = new System.Windows.Forms.Button();
            this.btnArrOddEven = new System.Windows.Forms.Button();
            this.btnArrMaxMin = new System.Windows.Forms.Button();
            this.btnArrLong = new System.Windows.Forms.Button();
            this.btnArrCc = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn101010 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.labAnswer = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(98, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(260, 38);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(148, 39);
            this.txtNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(489, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // btnOddEven
            // 
            this.btnOddEven.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOddEven.Location = new System.Drawing.Point(424, 28);
            this.btnOddEven.Margin = new System.Windows.Forms.Padding(4);
            this.btnOddEven.Name = "btnOddEven";
            this.btnOddEven.Size = new System.Drawing.Size(278, 58);
            this.btnOddEven.TabIndex = 5;
            this.btnOddEven.Text = "輸入的數為奇數偶數?";
            this.btnOddEven.UseVisualStyleBackColor = true;
            this.btnOddEven.Click += new System.EventHandler(this.btnOddEven_Click);
            // 
            // btnArrOddEven
            // 
            this.btnArrOddEven.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrOddEven.Location = new System.Drawing.Point(28, 107);
            this.btnArrOddEven.Margin = new System.Windows.Forms.Padding(4);
            this.btnArrOddEven.Name = "btnArrOddEven";
            this.btnArrOddEven.Size = new System.Drawing.Size(273, 64);
            this.btnArrOddEven.TabIndex = 6;
            this.btnArrOddEven.Text = "陣列Arr[]統計奇偶數";
            this.btnArrOddEven.UseVisualStyleBackColor = true;
            this.btnArrOddEven.Click += new System.EventHandler(this.btnArrOddEven_Click);
            // 
            // btnArrMaxMin
            // 
            this.btnArrMaxMin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrMaxMin.Location = new System.Drawing.Point(58, 213);
            this.btnArrMaxMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnArrMaxMin.Name = "btnArrMaxMin";
            this.btnArrMaxMin.Size = new System.Drawing.Size(273, 63);
            this.btnArrMaxMin.TabIndex = 7;
            this.btnArrMaxMin.Text = "陣列Arr[]最大/最小值";
            this.btnArrMaxMin.UseVisualStyleBackColor = true;
            this.btnArrMaxMin.Click += new System.EventHandler(this.btnArrMaxMin_Click);
            // 
            // btnArrLong
            // 
            this.btnArrLong.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrLong.Location = new System.Drawing.Point(58, 466);
            this.btnArrLong.Margin = new System.Windows.Forms.Padding(4);
            this.btnArrLong.Name = "btnArrLong";
            this.btnArrLong.Size = new System.Drawing.Size(243, 74);
            this.btnArrLong.TabIndex = 10;
            this.btnArrLong.Text = "陣列Arr_str[]最長";
            this.btnArrLong.UseVisualStyleBackColor = true;
            this.btnArrLong.Click += new System.EventHandler(this.btnArrLong_Click);
            // 
            // btnArrCc
            // 
            this.btnArrCc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrCc.Location = new System.Drawing.Point(58, 656);
            this.btnArrCc.Margin = new System.Windows.Forms.Padding(4);
            this.btnArrCc.Name = "btnArrCc";
            this.btnArrCc.Size = new System.Drawing.Size(309, 78);
            this.btnArrCc.TabIndex = 9;
            this.btnArrCc.Text = "陣列cCena[]C/c各有幾個";
            this.btnArrCc.UseVisualStyleBackColor = true;
            this.btnArrCc.Click += new System.EventHandler(this.btnArrCc_Click);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn10.Location = new System.Drawing.Point(927, 54);
            this.btn10.Margin = new System.Windows.Forms.Padding(4);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(320, 68);
            this.btn10.TabIndex = 8;
            this.btn10.Text = "[10,10]二維陣列-邊1內0";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn01
            // 
            this.btn01.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01.Location = new System.Drawing.Point(927, 180);
            this.btn01.Margin = new System.Windows.Forms.Padding(4);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(320, 74);
            this.btn01.TabIndex = 13;
            this.btn01.Text = "[10,10]二維陣列-邊0內1";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn101010
            // 
            this.btn101010.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn101010.Location = new System.Drawing.Point(940, 308);
            this.btn101010.Margin = new System.Windows.Forms.Padding(4);
            this.btn101010.Name = "btn101010";
            this.btn101010.Size = new System.Drawing.Size(320, 72);
            this.btn101010.TabIndex = 12;
            this.btn101010.Text = "[10,10]二維陣列-101010";
            this.btn101010.UseVisualStyleBackColor = true;
            this.btn101010.Click += new System.EventHandler(this.btn101010_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwap.Location = new System.Drawing.Point(1100, 495);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(201, 120);
            this.btnSwap.TabIndex = 11;
            this.btnSwap.Text = "Swap[int,int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // labAnswer
            // 
            this.labAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labAnswer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.Location = new System.Drawing.Point(490, 420);
            this.labAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(550, 314);
            this.labAnswer.TabIndex = 14;
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSum.Location = new System.Drawing.Point(424, 123);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(273, 63);
            this.btnSum.TabIndex = 15;
            this.btnSum.Text = "陣列Arr[]Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 826);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn101010);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnArrLong);
            this.Controls.Add(this.btnArrCc);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btnArrMaxMin);
            this.Controls.Add(this.btnArrOddEven);
            this.Controls.Add(this.btnOddEven);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArrayForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOddEven;
        private System.Windows.Forms.Button btnArrOddEven;
        private System.Windows.Forms.Button btnArrMaxMin;
        private System.Windows.Forms.Button btnArrLong;
        private System.Windows.Forms.Button btnArrCc;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn101010;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.Button btnSum;
    }
}