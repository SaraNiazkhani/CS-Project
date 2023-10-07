namespace CS_Project
{
    partial class LoginForm
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
            FirstNamelabel = new Label();
            Cellphonelabel = new Label();
            LastNamelabel = new Label();
            LoginBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // FirstNamelabel
            // 
            FirstNamelabel.AutoSize = true;
            FirstNamelabel.Location = new Point(23, 24);
            FirstNamelabel.Name = "FirstNamelabel";
            FirstNamelabel.Size = new Size(70, 15);
            FirstNamelabel.TabIndex = 0;
            FirstNamelabel.Text = "First Name :";
            // 
            // Cellphonelabel
            // 
            Cellphonelabel.AutoSize = true;
            Cellphonelabel.Location = new Point(23, 103);
            Cellphonelabel.Name = "Cellphonelabel";
            Cellphonelabel.Size = new Size(67, 15);
            Cellphonelabel.TabIndex = 1;
            Cellphonelabel.Text = "Cellphone :";
            // 
            // LastNamelabel
            // 
            LastNamelabel.AutoSize = true;
            LastNamelabel.Location = new Point(23, 63);
            LastNamelabel.Name = "LastNamelabel";
            LastNamelabel.Size = new Size(69, 15);
            LastNamelabel.TabIndex = 1;
            LastNamelabel.Text = "Last Name :";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.SandyBrown;
            LoginBtn.Location = new Point(211, 147);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(97, 41);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(344, 217);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LoginBtn);
            Controls.Add(LastNamelabel);
            Controls.Add(Cellphonelabel);
            Controls.Add(FirstNamelabel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNamelabel;
        private Label Cellphonelabel;
        private Label LastNamelabel;
        private Button LoginBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}