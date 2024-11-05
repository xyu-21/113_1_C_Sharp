namespace CheckBoxDEmo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton5 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft JhengHei UI", 11F);
            radioButton2.Location = new Point(43, 102);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 23);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "炸雞";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += this.radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft JhengHei UI", 11F);
            radioButton3.Location = new Point(43, 186);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(57, 23);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "比薩";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += this.radioButton3_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Microsoft JhengHei UI", 11F);
            radioButton5.Location = new Point(44, 55);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(57, 23);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "可樂";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(68, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 299);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "主餐";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Location = new Point(426, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 299);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "飲料";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Microsoft JhengHei UI", 11F);
            radioButton6.Location = new Point(44, 145);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(72, 23);
            radioButton6.TabIndex = 9;
            radioButton6.TabStop = true;
            radioButton6.Text = "冰咖啡";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Microsoft JhengHei UI", 11F);
            radioButton7.Location = new Point(44, 102);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(57, 23);
            radioButton7.TabIndex = 10;
            radioButton7.TabStop = true;
            radioButton7.Text = "雪碧";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("Microsoft JhengHei UI", 11F);
            radioButton8.Location = new Point(43, 55);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(57, 23);
            radioButton8.TabIndex = 8;
            radioButton8.TabStop = true;
            radioButton8.Text = "漢堡";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft JhengHei UI", 11F);
            radioButton1.Location = new Point(43, 145);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 23);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "牛排";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton8;
        private RadioButton radioButton1;
    }
}
