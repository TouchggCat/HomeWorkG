
namespace HomeWorkG
{
    partial class StudentGrade
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
            this.txtStat = new System.Windows.Forms.RichTextBox();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.btnR20 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.btnRan = new System.Windows.Forms.Button();
            this.btnAddS = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStat
            // 
            this.txtStat.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStat.Location = new System.Drawing.Point(459, 379);
            this.txtStat.Margin = new System.Windows.Forms.Padding(4);
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(558, 139);
            this.txtStat.TabIndex = 29;
            this.txtStat.Text = "";
            // 
            // txtMain
            // 
            this.txtMain.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMain.Location = new System.Drawing.Point(459, 45);
            this.txtMain.Margin = new System.Windows.Forms.Padding(4);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(595, 310);
            this.txtMain.TabIndex = 28;
            this.txtMain.Text = "姓名    國文    英文    數學     總分    平均    最低    最高";
            // 
            // btnR20
            // 
            this.btnR20.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnR20.Location = new System.Drawing.Point(181, 431);
            this.btnR20.Margin = new System.Windows.Forms.Padding(4);
            this.btnR20.Name = "btnR20";
            this.btnR20.Size = new System.Drawing.Size(221, 40);
            this.btnR20.TabIndex = 27;
            this.btnR20.Text = "隨機加入20筆";
            this.btnR20.UseVisualStyleBackColor = true;
            this.btnR20.Click += new System.EventHandler(this.btnR20_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(181, 479);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(221, 40);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStat
            // 
            this.btnStat.Enabled = false;
            this.btnStat.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStat.Location = new System.Drawing.Point(181, 335);
            this.btnStat.Margin = new System.Windows.Forms.Padding(4);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(221, 40);
            this.btnStat.TabIndex = 25;
            this.btnStat.Text = "各科統計";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // btnRan
            // 
            this.btnRan.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRan.Location = new System.Drawing.Point(181, 288);
            this.btnRan.Margin = new System.Windows.Forms.Padding(4);
            this.btnRan.Name = "btnRan";
            this.btnRan.Size = new System.Drawing.Size(221, 40);
            this.btnRan.TabIndex = 24;
            this.btnRan.Text = "隨機儲存資料";
            this.btnRan.UseVisualStyleBackColor = true;
            this.btnRan.Click += new System.EventHandler(this.btnRan_Click);
            // 
            // btnAddS
            // 
            this.btnAddS.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddS.Location = new System.Drawing.Point(181, 240);
            this.btnAddS.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(221, 40);
            this.btnAddS.TabIndex = 23;
            this.btnAddS.Text = "加入學生資料";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(269, 205);
            this.txtMath.Margin = new System.Windows.Forms.Padding(4);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(132, 25);
            this.txtMath.TabIndex = 22;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(269, 155);
            this.txtEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(132, 25);
            this.txtEnglish.TabIndex = 21;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(269, 99);
            this.txtChinese.Margin = new System.Windows.Forms.Padding(4);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(132, 25);
            this.txtChinese.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(269, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 25);
            this.txtName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(176, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "數學:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(176, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "英文:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(176, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "國文:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(176, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "姓名:";
            // 
            // StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.txtStat);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnR20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnRan);
            this.Controls.Add(this.btnAddS);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentGrade";
            this.Text = "StudentGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtStat;
        private System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.Button btnR20;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Button btnRan;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}