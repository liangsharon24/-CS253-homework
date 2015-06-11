namespace homework02
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.number3TextBox = new System.Windows.Forms.TextBox();
            this.number4TextBox = new System.Windows.Forms.TextBox();
            this.total1TextBox = new System.Windows.Forms.TextBox();
            this.total2TextBox = new System.Windows.Forms.TextBox();
            this.alltotalTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(58, 53);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(100, 22);
            this.number1TextBox.TabIndex = 0;
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(218, 53);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(100, 22);
            this.number2TextBox.TabIndex = 1;
            // 
            // number3TextBox
            // 
            this.number3TextBox.Location = new System.Drawing.Point(366, 53);
            this.number3TextBox.Name = "number3TextBox";
            this.number3TextBox.Size = new System.Drawing.Size(100, 22);
            this.number3TextBox.TabIndex = 2;
            // 
            // number4TextBox
            // 
            this.number4TextBox.Location = new System.Drawing.Point(514, 53);
            this.number4TextBox.Name = "number4TextBox";
            this.number4TextBox.Size = new System.Drawing.Size(100, 22);
            this.number4TextBox.TabIndex = 3;
            // 
            // total1TextBox
            // 
            this.total1TextBox.Location = new System.Drawing.Point(136, 141);
            this.total1TextBox.Name = "total1TextBox";
            this.total1TextBox.Size = new System.Drawing.Size(100, 22);
            this.total1TextBox.TabIndex = 4;
            // 
            // total2TextBox
            // 
            this.total2TextBox.Location = new System.Drawing.Point(438, 141);
            this.total2TextBox.Name = "total2TextBox";
            this.total2TextBox.Size = new System.Drawing.Size(100, 22);
            this.total2TextBox.TabIndex = 5;
            // 
            // alltotalTextBox
            // 
            this.alltotalTextBox.Location = new System.Drawing.Point(294, 221);
            this.alltotalTextBox.Name = "alltotalTextBox";
            this.alltotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.alltotalTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(308, 283);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 332);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.alltotalTextBox);
            this.Controls.Add(this.total2TextBox);
            this.Controls.Add(this.total1TextBox);
            this.Controls.Add(this.number4TextBox);
            this.Controls.Add(this.number3TextBox);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.TextBox number3TextBox;
        private System.Windows.Forms.TextBox number4TextBox;
        private System.Windows.Forms.TextBox total1TextBox;
        private System.Windows.Forms.TextBox total2TextBox;
        private System.Windows.Forms.TextBox alltotalTextBox;
        private System.Windows.Forms.Button addButton;
    }
}

