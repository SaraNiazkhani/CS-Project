namespace CS_Project
{
    partial class CreateAccountForm
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
            FirstNamelable = new Label();
            LastNamelabel = new Label();
            NationalCodelabel = new Label();
            label4 = new Label();
            Genderlabel = new Label();
            IsAdminlabel = new Label();
            label7 = new Label();
            RoleNamelabel = new Label();
            LastNameTxt = new TextBox();
            NationalCodeTxt = new TextBox();
            FirstNameTxt = new TextBox();
            CellphoneTxt = new TextBox();
            GendercomboBox = new ComboBox();
            IsAdmincheckBox = new CheckBox();
            AccessIdTxt = new TextBox();
            SaveBtn = new Button();
            dataGridView = new DataGridView();
            UserIdlabel = new Label();
            UserIdTxt = new TextBox();
            RoleNameComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // FirstNamelable
            // 
            FirstNamelable.AutoSize = true;
            FirstNamelable.Location = new Point(17, 25);
            FirstNamelable.Name = "FirstNamelable";
            FirstNamelable.Size = new Size(67, 15);
            FirstNamelable.TabIndex = 0;
            FirstNamelable.Text = "FirstName :";
            // 
            // LastNamelabel
            // 
            LastNamelabel.AutoSize = true;
            LastNamelabel.Location = new Point(283, 25);
            LastNamelabel.Name = "LastNamelabel";
            LastNamelabel.Size = new Size(66, 15);
            LastNamelabel.TabIndex = 1;
            LastNamelabel.Text = "LastName :";
            // 
            // NationalCodelabel
            // 
            NationalCodelabel.AutoSize = true;
            NationalCodelabel.Location = new Point(17, 64);
            NationalCodelabel.Name = "NationalCodelabel";
            NationalCodelabel.Size = new Size(84, 15);
            NationalCodelabel.TabIndex = 2;
            NationalCodelabel.Text = "Nationalcode :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 64);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Cellphone :";
            // 
            // Genderlabel
            // 
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(17, 108);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(51, 15);
            Genderlabel.TabIndex = 4;
            Genderlabel.Text = "Gender :";
            // 
            // IsAdminlabel
            // 
            IsAdminlabel.AutoSize = true;
            IsAdminlabel.Location = new Point(17, 149);
            IsAdminlabel.Name = "IsAdminlabel";
            IsAdminlabel.Size = new Size(57, 15);
            IsAdminlabel.TabIndex = 5;
            IsAdminlabel.Text = "IsAdmin :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 226);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "Access Id :";
            // 
            // RoleNamelabel
            // 
            RoleNamelabel.AutoSize = true;
            RoleNamelabel.Location = new Point(17, 188);
            RoleNamelabel.Name = "RoleNamelabel";
            RoleNamelabel.Size = new Size(71, 15);
            RoleNamelabel.TabIndex = 7;
            RoleNamelabel.Text = "Role Name :";
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new Point(374, 21);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(162, 23);
            LastNameTxt.TabIndex = 9;
            // 
            // NationalCodeTxt
            // 
            NationalCodeTxt.Location = new Point(104, 61);
            NationalCodeTxt.Name = "NationalCodeTxt";
            NationalCodeTxt.Size = new Size(162, 23);
            NationalCodeTxt.TabIndex = 10;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new Point(104, 21);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(162, 23);
            FirstNameTxt.TabIndex = 11;
            // 
            // CellphoneTxt
            // 
            CellphoneTxt.Location = new Point(374, 61);
            CellphoneTxt.Name = "CellphoneTxt";
            CellphoneTxt.Size = new Size(162, 23);
            CellphoneTxt.TabIndex = 12;
            // 
            // GendercomboBox
            // 
            GendercomboBox.FormattingEnabled = true;
            GendercomboBox.Items.AddRange(new object[] { "Female", "Male" });
            GendercomboBox.Location = new Point(104, 105);
            GendercomboBox.Name = "GendercomboBox";
            GendercomboBox.Size = new Size(138, 23);
            GendercomboBox.TabIndex = 13;
            // 
            // IsAdmincheckBox
            // 
            IsAdmincheckBox.AutoSize = true;
            IsAdmincheckBox.Location = new Point(104, 149);
            IsAdmincheckBox.Name = "IsAdmincheckBox";
            IsAdmincheckBox.Size = new Size(15, 14);
            IsAdmincheckBox.TabIndex = 14;
            IsAdmincheckBox.UseVisualStyleBackColor = false;
           
            IsAdmincheckBox.EnabledChanged += SaveBtn_Click;
            // 
            // AccessIdTxt
            // 
            AccessIdTxt.Enabled = false;
            AccessIdTxt.Location = new Point(104, 223);
            AccessIdTxt.Name = "AccessIdTxt";
            AccessIdTxt.Size = new Size(162, 23);
            AccessIdTxt.TabIndex = 16;
           
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.SandyBrown;
            SaveBtn.Location = new Point(398, 242);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(138, 37);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Window;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 289);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(550, 169);
            dataGridView.TabIndex = 18;
            // 
            // UserIdlabel
            // 
            UserIdlabel.AutoSize = true;
            UserIdlabel.Location = new Point(283, 108);
            UserIdlabel.Name = "UserIdlabel";
            UserIdlabel.Size = new Size(52, 15);
            UserIdlabel.TabIndex = 19;
            UserIdlabel.Text = "User Id : ";
            // 
            // UserIdTxt
            // 
            UserIdTxt.Location = new Point(374, 105);
            UserIdTxt.Name = "UserIdTxt";
            UserIdTxt.Size = new Size(162, 23);
            UserIdTxt.TabIndex = 20;
            
            // 
            // RoleNameComboBox
            // 
            RoleNameComboBox.Enabled = false;
            RoleNameComboBox.FormattingEnabled = true;
            RoleNameComboBox.Items.AddRange(new object[] { " Manager", "", " CPO", " Teamleader", " Supervisor", "", " Analyst", "Director", "CEO" });
            RoleNameComboBox.Location = new Point(104, 180);
            RoleNameComboBox.Name = "RoleNameComboBox";
            RoleNameComboBox.Size = new Size(138, 23);
            RoleNameComboBox.TabIndex = 21;
            
            
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(574, 470);
            Controls.Add(RoleNameComboBox);
            Controls.Add(UserIdTxt);
            Controls.Add(UserIdlabel);
            Controls.Add(dataGridView);
            Controls.Add(SaveBtn);
            Controls.Add(AccessIdTxt);
            Controls.Add(IsAdmincheckBox);
            Controls.Add(GendercomboBox);
            Controls.Add(CellphoneTxt);
            Controls.Add(FirstNameTxt);
            Controls.Add(NationalCodeTxt);
            Controls.Add(LastNameTxt);
            Controls.Add(RoleNamelabel);
            Controls.Add(label7);
            Controls.Add(IsAdminlabel);
            Controls.Add(Genderlabel);
            Controls.Add(label4);
            Controls.Add(NationalCodelabel);
            Controls.Add(LastNamelabel);
            Controls.Add(FirstNamelable);
            Name = "CreateAccountForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNamelable;
        private Label LastNamelabel;
        private Label NationalCodelabel;
        private Label label4;
        private Label Genderlabel;
        private Label IsAdminlabel;
        private Label label7;
        private Label RoleNamelabel;
        private TextBox LastNameTxt;
        private TextBox NationalCodeTxt;
        private TextBox FirstNameTxt;
        private TextBox CellphoneTxt;
        private ComboBox GendercomboBox;
        private CheckBox IsAdmincheckBox;
        private TextBox AccessIdTxt;
        private Button SaveBtn;
        private DataGridView dataGridView;
        private Label UserIdlabel;
        private TextBox UserIdTxt;
        private ComboBox RoleNameComboBox;
    }
}