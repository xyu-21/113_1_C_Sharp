namespace A111221046_HW2_2
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
            lblTotal = new Label();
            txtCash = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(txtCash);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 11F);
            groupBox1.Location = new Point(43, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "信用卡積分";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Location = new Point(157, 152);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(217, 31);
            lblTotal.TabIndex = 4;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCash
            // 
            txtCash.Location = new Point(157, 103);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(217, 31);
            txtCash.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 152);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 2;
            label3.Text = "擁有積分數：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 106);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 1;
            label2.Text = "購買金額：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 49);
            label1.Name = "label1";
            label1.Size = new Size(314, 24);
            label1.TabIndex = 0;
            label1.Text = "輸入一個月內購買金額以顯示積分數";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(56, 320);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "計算點數";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(223, 320);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "清空";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(398, 320);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 400);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label lblTotal;
        private TextBox txtCash;
        private Label label3;
        private Label label2;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
