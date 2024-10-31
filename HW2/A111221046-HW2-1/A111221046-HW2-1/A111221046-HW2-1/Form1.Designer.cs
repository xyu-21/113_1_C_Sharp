namespace A111221046_HW2_1
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
            groupBox1 = new GroupBox();
            txtSoldC = new TextBox();
            txtSoldB = new TextBox();
            txtSoldA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            lblC = new Label();
            lblB = new Label();
            lblA = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoldC);
            groupBox1.Controls.Add(txtSoldB);
            groupBox1.Controls.Add(txtSoldA);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 11F);
            groupBox1.Location = new Point(48, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "已售門票";
            // 
            // txtSoldC
            // 
            txtSoldC.Location = new Point(124, 193);
            txtSoldC.Name = "txtSoldC";
            txtSoldC.Size = new Size(166, 31);
            txtSoldC.TabIndex = 6;
            // 
            // txtSoldB
            // 
            txtSoldB.Location = new Point(124, 147);
            txtSoldB.Name = "txtSoldB";
            txtSoldB.Size = new Size(166, 31);
            txtSoldB.TabIndex = 5;
            // 
            // txtSoldA
            // 
            txtSoldA.Location = new Point(124, 103);
            txtSoldA.Name = "txtSoldA";
            txtSoldA.Size = new Size(166, 31);
            txtSoldA.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 196);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 3;
            label4.Text = "類別 C：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 150);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 2;
            label3.Text = "類別 B：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 106);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 1;
            label2.Text = "類別 A：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 54);
            label1.Name = "label1";
            label1.Size = new Size(257, 24);
            label1.TabIndex = 0;
            label1.Text = "輸入每種座位的已售門票數量";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(lblC);
            groupBox2.Controls.Add(lblB);
            groupBox2.Controls.Add(lblA);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Microsoft JhengHei UI", 11F);
            groupBox2.Location = new Point(427, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 256);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "收入";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            lblTotal.Location = new Point(144, 193);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(128, 23);
            lblTotal.TabIndex = 9;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC
            // 
            lblC.BorderStyle = BorderStyle.FixedSingle;
            lblC.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            lblC.Location = new Point(144, 147);
            lblC.Name = "lblC";
            lblC.Size = new Size(128, 23);
            lblC.TabIndex = 8;
            lblC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            lblB.BorderStyle = BorderStyle.FixedSingle;
            lblB.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            lblB.Location = new Point(144, 106);
            lblB.Name = "lblB";
            lblB.Size = new Size(128, 23);
            lblB.TabIndex = 7;
            lblB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            lblA.BorderStyle = BorderStyle.FixedSingle;
            lblA.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            lblA.Location = new Point(144, 65);
            lblA.Name = "lblA";
            lblA.Size = new Size(128, 23);
            lblA.TabIndex = 6;
            lblA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 193);
            label8.Name = "label8";
            label8.Size = new Size(67, 24);
            label8.TabIndex = 5;
            label8.Text = "總共：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 150);
            label7.Name = "label7";
            label7.Size = new Size(85, 24);
            label7.TabIndex = 4;
            label7.Text = "類別 C：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 106);
            label6.Name = "label6";
            label6.Size = new Size(84, 24);
            label6.TabIndex = 3;
            label6.Text = "類別 B：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 65);
            label5.Name = "label5";
            label5.Size = new Size(85, 24);
            label5.TabIndex = 2;
            label5.Text = "類別 A：";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(143, 345);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(126, 48);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "計算收益";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(333, 345);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 48);
            btnClear.TabIndex = 3;
            btnClear.Text = "清空";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(534, 345);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 48);
            btnExit.TabIndex = 4;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 432);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "體育場座位";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSoldC;
        private TextBox txtSoldB;
        private TextBox txtSoldA;
        private Label lblA;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblTotal;
        private Label lblC;
        private Label lblB;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
