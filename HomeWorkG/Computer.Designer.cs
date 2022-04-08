
namespace HomeWorkG
{
    partial class Computer
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btnM = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(189, 41);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 22);
            this.txtN1.TabIndex = 0;
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(359, 39);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 1;
            this.btnP.Text = "+";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(359, 84);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 3;
            this.btnS.Text = "-";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(189, 112);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 22);
            this.txtN2.TabIndex = 2;
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(359, 131);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(75, 23);
            this.btnM.TabIndex = 5;
            this.btnM.Text = "x";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(189, 245);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 4;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(359, 176);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 7;
            this.btnD.Text = "/";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(64, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "==========================";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(79, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Answer:";
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(359, 243);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 12;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 309);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.txtN1);
            this.Name = "Computer";
            this.Text = "小小小算盤";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnC;
    }
}