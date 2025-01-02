namespace _20241217_hw1
{
    partial class Form9
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
            this.button_Beverage = new System.Windows.Forms.Button();
            this.button_MoneySlot_100 = new System.Windows.Forms.Button();
            this.textBox_Beverage = new System.Windows.Forms.TextBox();
            this.textBox_MoneySlot = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_MoneySlot_1000 = new System.Windows.Forms.Button();
            this.button_MoneySlot_500 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Beverage
            // 
            this.button_Beverage.Location = new System.Drawing.Point(180, 137);
            this.button_Beverage.Name = "button_Beverage";
            this.button_Beverage.Size = new System.Drawing.Size(105, 61);
            this.button_Beverage.TabIndex = 0;
            this.button_Beverage.Text = "음료";
            this.button_Beverage.UseVisualStyleBackColor = true;
            this.button_Beverage.Click += new System.EventHandler(this.button_Beverage_Click);
            // 
            // button_MoneySlot_100
            // 
            this.button_MoneySlot_100.Location = new System.Drawing.Point(476, 137);
            this.button_MoneySlot_100.Name = "button_MoneySlot_100";
            this.button_MoneySlot_100.Size = new System.Drawing.Size(105, 61);
            this.button_MoneySlot_100.TabIndex = 1;
            this.button_MoneySlot_100.Text = "100원";
            this.button_MoneySlot_100.UseVisualStyleBackColor = true;
            this.button_MoneySlot_100.Click += new System.EventHandler(this.button_MoneySlot_Click);
            // 
            // textBox_Beverage
            // 
            this.textBox_Beverage.Location = new System.Drawing.Point(111, 60);
            this.textBox_Beverage.Multiline = true;
            this.textBox_Beverage.Name = "textBox_Beverage";
            this.textBox_Beverage.Size = new System.Drawing.Size(101, 60);
            this.textBox_Beverage.TabIndex = 2;
            // 
            // textBox_MoneySlot
            // 
            this.textBox_MoneySlot.Location = new System.Drawing.Point(476, 95);
            this.textBox_MoneySlot.Multiline = true;
            this.textBox_MoneySlot.Name = "textBox_MoneySlot";
            this.textBox_MoneySlot.Size = new System.Drawing.Size(100, 25);
            this.textBox_MoneySlot.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 60);
            this.textBox1.TabIndex = 4;
            // 
            // button_MoneySlot_1000
            // 
            this.button_MoneySlot_1000.Location = new System.Drawing.Point(476, 271);
            this.button_MoneySlot_1000.Name = "button_MoneySlot_1000";
            this.button_MoneySlot_1000.Size = new System.Drawing.Size(105, 61);
            this.button_MoneySlot_1000.TabIndex = 5;
            this.button_MoneySlot_1000.Text = "1000원";
            this.button_MoneySlot_1000.UseVisualStyleBackColor = true;
            // 
            // button_MoneySlot_500
            // 
            this.button_MoneySlot_500.Location = new System.Drawing.Point(476, 204);
            this.button_MoneySlot_500.Name = "button_MoneySlot_500";
            this.button_MoneySlot_500.Size = new System.Drawing.Size(105, 61);
            this.button_MoneySlot_500.TabIndex = 6;
            this.button_MoneySlot_500.Text = "500원";
            this.button_MoneySlot_500.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_MoneySlot_500);
            this.Controls.Add(this.button_MoneySlot_1000);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_MoneySlot);
            this.Controls.Add(this.textBox_Beverage);
            this.Controls.Add(this.button_MoneySlot_100);
            this.Controls.Add(this.button_Beverage);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Beverage;
        private System.Windows.Forms.Button button_MoneySlot_100;
        private System.Windows.Forms.TextBox textBox_Beverage;
        private System.Windows.Forms.TextBox textBox_MoneySlot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_MoneySlot_1000;
        private System.Windows.Forms.Button button_MoneySlot_500;
    }
}