namespace HelloWorld
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
            btnDisplay = new Button();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.SteelBlue;
            btnDisplay.Font = new Font("Microsoft JhengHei UI", 20F);
            btnDisplay.ForeColor = SystemColors.HighlightText;
            btnDisplay.Location = new Point(260, 428);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(291, 54);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display Message";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(838, 494);
            Controls.Add(btnDisplay);
            Name = "Form1";
            Text = "Greeting!";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplay;
    }
}
