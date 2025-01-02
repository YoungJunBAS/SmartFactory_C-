namespace _20241217_hw1
{
    partial class Form10
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
            this.components = new System.ComponentModel.Container();
            this.textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_checking = new System.Windows.Forms.Button();
            this.button_battle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.Location = new System.Drawing.Point(12, 31);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(776, 266);
            this.textBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_checking
            // 
            this.button_checking.Location = new System.Drawing.Point(12, 303);
            this.button_checking.Name = "button_checking";
            this.button_checking.Size = new System.Drawing.Size(98, 118);
            this.button_checking.TabIndex = 2;
            this.button_checking.Text = "확인";
            this.button_checking.UseVisualStyleBackColor = true;
            this.button_checking.Click += new System.EventHandler(this.button_checking_Click);
            // 
            // button_battle
            // 
            this.button_battle.Location = new System.Drawing.Point(690, 303);
            this.button_battle.Name = "button_battle";
            this.button_battle.Size = new System.Drawing.Size(98, 118);
            this.button_battle.TabIndex = 3;
            this.button_battle.Text = "배틀!";
            this.button_battle.UseVisualStyleBackColor = true;
            this.button_battle.Click += new System.EventHandler(this.button_battle_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_battle);
            this.Controls.Add(this.button_checking);
            this.Controls.Add(this.textBox);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_checking;
        private System.Windows.Forms.Button button_battle;
    }
}