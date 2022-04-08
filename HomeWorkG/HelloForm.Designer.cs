
namespace HomeWorkG
{
    partial class HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHello = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labEngName = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labHight = new System.Windows.Forms.Label();
            this.txtHight = new System.Windows.Forms.TextBox();
            this.txtEngName = new System.Windows.Forms.TextBox();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(282, 358);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(138, 76);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(198, 70);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(42, 21);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(320, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 29);
            this.txtName.TabIndex = 2;
            // 
            // labEngName
            // 
            this.labEngName.AutoSize = true;
            this.labEngName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngName.Location = new System.Drawing.Point(164, 135);
            this.labEngName.Name = "labEngName";
            this.labEngName.Size = new System.Drawing.Size(115, 21);
            this.labEngName.TabIndex = 3;
            this.labEngName.Text = "English Name";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSex.Location = new System.Drawing.Point(198, 201);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(42, 21);
            this.labSex.TabIndex = 4;
            this.labSex.Text = "性別";
            // 
            // labHight
            // 
            this.labHight.AutoSize = true;
            this.labHight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHight.Location = new System.Drawing.Point(198, 265);
            this.labHight.Name = "labHight";
            this.labHight.Size = new System.Drawing.Size(42, 21);
            this.labHight.TabIndex = 5;
            this.labHight.Text = "身高";
            // 
            // txtHight
            // 
            this.txtHight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHight.Location = new System.Drawing.Point(320, 257);
            this.txtHight.Name = "txtHight";
            this.txtHight.Size = new System.Drawing.Size(100, 29);
            this.txtHight.TabIndex = 6;
            // 
            // txtEngName
            // 
            this.txtEngName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngName.Location = new System.Drawing.Point(320, 129);
            this.txtEngName.Name = "txtEngName";
            this.txtEngName.Size = new System.Drawing.Size(100, 27);
            this.txtEngName.TabIndex = 7;
            // 
            // comboSex
            // 
            this.comboSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Items.AddRange(new object[] {
            "男生",
            "女生"});
            this.comboSex.Location = new System.Drawing.Point(320, 193);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(100, 29);
            this.comboSex.TabIndex = 8;
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeWorkG.Properties.Resources.b3a4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 495);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.txtEngName);
            this.Controls.Add(this.txtHight);
            this.Controls.Add(this.labHight);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labEngName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnHello);
            this.DoubleBuffered = true;
            this.Name = "HelloForm";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labEngName;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labHight;
        private System.Windows.Forms.TextBox txtHight;
        private System.Windows.Forms.TextBox txtEngName;
        private System.Windows.Forms.ComboBox comboSex;
    }
}

