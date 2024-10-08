namespace Tutorial2_5
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
            ptxFront = new PictureBox();
            ptxBack = new PictureBox();
            btnShowback = new Button();
            btnShowfront = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxFront).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            SuspendLayout();
            // 
            // ptxFront
            // 
            ptxFront.Image = Properties.Resources.Ace_Spades;
            ptxFront.Location = new Point(258, 38);
            ptxFront.Name = "ptxFront";
            ptxFront.Size = new Size(196, 242);
            ptxFront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxFront.TabIndex = 0;
            ptxFront.TabStop = false;
            ptxFront.Visible = false;
            // 
            // ptxBack
            // 
            ptxBack.Image = Properties.Resources.Backface_Blue;
            ptxBack.Location = new Point(29, 38);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(196, 242);
            ptxBack.SizeMode = PictureBoxSizeMode.Zoom;
            ptxBack.TabIndex = 1;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            // 
            // btnShowback
            // 
            btnShowback.Location = new Point(64, 321);
            btnShowback.Name = "btnShowback";
            btnShowback.Size = new Size(120, 50);
            btnShowback.TabIndex = 2;
            btnShowback.Text = "背面";
            btnShowback.UseVisualStyleBackColor = true;
            btnShowback.Click += btnShowback_Click;
            // 
            // btnShowfront
            // 
            btnShowfront.Location = new Point(302, 321);
            btnShowfront.Name = "btnShowfront";
            btnShowfront.Size = new Size(120, 50);
            btnShowfront.TabIndex = 3;
            btnShowfront.Text = "正面";
            btnShowfront.UseVisualStyleBackColor = true;
            btnShowfront.Click += btnShowfront_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(478, 402);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 437);
            Controls.Add(btnExit);
            Controls.Add(btnShowfront);
            Controls.Add(btnShowback);
            Controls.Add(ptxBack);
            Controls.Add(ptxFront);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxFront).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxFront;
        private PictureBox ptxBack;
        private Button btnShowback;
        private Button btnShowfront;
        private Button btnExit;
    }
}
