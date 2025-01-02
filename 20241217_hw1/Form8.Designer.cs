namespace _20241217_hw1
{
    partial class Form8
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
            this.textBox_unusing_me = new System.Windows.Forms.TextBox();
            this.radioButton_scissors = new System.Windows.Forms.RadioButton();
            this.radioButton_rock = new System.Windows.Forms.RadioButton();
            this.radioButton_paper = new System.Windows.Forms.RadioButton();
            this.textBox_unusing_cpu = new System.Windows.Forms.TextBox();
            this.textBox_cpu_result = new System.Windows.Forms.TextBox();
            this.textBox_score_me = new System.Windows.Forms.TextBox();
            this.textBox_score_cpu = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_unusing_me
            // 
            this.textBox_unusing_me.Location = new System.Drawing.Point(52, 44);
            this.textBox_unusing_me.Name = "textBox_unusing_me";
            this.textBox_unusing_me.Size = new System.Drawing.Size(100, 25);
            this.textBox_unusing_me.TabIndex = 0;
            this.textBox_unusing_me.Text = "나";
            this.textBox_unusing_me.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton_scissors
            // 
            this.radioButton_scissors.AutoSize = true;
            this.radioButton_scissors.Location = new System.Drawing.Point(52, 90);
            this.radioButton_scissors.Name = "radioButton_scissors";
            this.radioButton_scissors.Size = new System.Drawing.Size(58, 19);
            this.radioButton_scissors.TabIndex = 1;
            this.radioButton_scissors.TabStop = true;
            this.radioButton_scissors.Text = "가위";
            this.radioButton_scissors.UseVisualStyleBackColor = true;
            this.radioButton_scissors.Click += new System.EventHandler(this.radioButton_scissors_Click);
            // 
            // radioButton_rock
            // 
            this.radioButton_rock.AutoSize = true;
            this.radioButton_rock.Location = new System.Drawing.Point(52, 140);
            this.radioButton_rock.Name = "radioButton_rock";
            this.radioButton_rock.Size = new System.Drawing.Size(58, 19);
            this.radioButton_rock.TabIndex = 2;
            this.radioButton_rock.TabStop = true;
            this.radioButton_rock.Text = "바위";
            this.radioButton_rock.UseVisualStyleBackColor = true;
            this.radioButton_rock.Click += new System.EventHandler(this.radioButton_rock_Click);
            // 
            // radioButton_paper
            // 
            this.radioButton_paper.AutoSize = true;
            this.radioButton_paper.Location = new System.Drawing.Point(52, 186);
            this.radioButton_paper.Name = "radioButton_paper";
            this.radioButton_paper.Size = new System.Drawing.Size(43, 19);
            this.radioButton_paper.TabIndex = 3;
            this.radioButton_paper.TabStop = true;
            this.radioButton_paper.Text = "보";
            this.radioButton_paper.UseVisualStyleBackColor = true;
            this.radioButton_paper.Click += new System.EventHandler(this.radioButton_paper_Click);
            // 
            // textBox_unusing_cpu
            // 
            this.textBox_unusing_cpu.Location = new System.Drawing.Point(629, 44);
            this.textBox_unusing_cpu.Name = "textBox_unusing_cpu";
            this.textBox_unusing_cpu.Size = new System.Drawing.Size(100, 25);
            this.textBox_unusing_cpu.TabIndex = 5;
            this.textBox_unusing_cpu.Text = "컴퓨터";
            this.textBox_unusing_cpu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_cpu_result
            // 
            this.textBox_cpu_result.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_cpu_result.Location = new System.Drawing.Point(629, 110);
            this.textBox_cpu_result.Multiline = true;
            this.textBox_cpu_result.Name = "textBox_cpu_result";
            this.textBox_cpu_result.ReadOnly = true;
            this.textBox_cpu_result.Size = new System.Drawing.Size(100, 95);
            this.textBox_cpu_result.TabIndex = 6;
            // 
            // textBox_score_me
            // 
            this.textBox_score_me.Location = new System.Drawing.Point(52, 230);
            this.textBox_score_me.Name = "textBox_score_me";
            this.textBox_score_me.Size = new System.Drawing.Size(100, 25);
            this.textBox_score_me.TabIndex = 8;
            // 
            // textBox_score_cpu
            // 
            this.textBox_score_cpu.Location = new System.Drawing.Point(629, 230);
            this.textBox_score_cpu.Name = "textBox_score_cpu";
            this.textBox_score_cpu.Size = new System.Drawing.Size(100, 25);
            this.textBox_score_cpu.TabIndex = 9;
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_result.Location = new System.Drawing.Point(52, 282);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(677, 137);
            this.textBox_result.TabIndex = 10;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_score_cpu);
            this.Controls.Add(this.textBox_score_me);
            this.Controls.Add(this.textBox_cpu_result);
            this.Controls.Add(this.textBox_unusing_cpu);
            this.Controls.Add(this.radioButton_paper);
            this.Controls.Add(this.radioButton_rock);
            this.Controls.Add(this.radioButton_scissors);
            this.Controls.Add(this.textBox_unusing_me);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_unusing_me;
        private System.Windows.Forms.RadioButton radioButton_scissors;
        private System.Windows.Forms.RadioButton radioButton_rock;
        private System.Windows.Forms.RadioButton radioButton_paper;
        private System.Windows.Forms.TextBox textBox_unusing_cpu;
        private System.Windows.Forms.TextBox textBox_cpu_result;
        private System.Windows.Forms.TextBox textBox_score_me;
        private System.Windows.Forms.TextBox textBox_score_cpu;
        private System.Windows.Forms.TextBox textBox_result;
    }
}