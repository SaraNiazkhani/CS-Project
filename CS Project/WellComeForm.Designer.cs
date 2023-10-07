namespace CS_Project
{
    partial class WellComeForm
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 36);
            label1.Margin = new Padding(3, 120, 3, 12);
            label1.Name = "label1";
            label1.Size = new Size(211, 62);
            label1.TabIndex = 0;
            label1.Text = "Well Come";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Location = new Point(31, 159);
            button1.Name = "button1";
            button1.Size = new Size(141, 54);
            button1.TabIndex = 1;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.Location = new Point(211, 159);
            button2.Name = "button2";
            button2.Size = new Size(141, 54);
            button2.TabIndex = 2;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // WellComeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(386, 259);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "WellComeForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}