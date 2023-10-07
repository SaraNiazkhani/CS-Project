using CS_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CS_Project
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
            GendercomboBox.DataSource = Enum.GetValues(typeof(@enum.Gender));
            RoleNameComboBox.DataSource = Enum.GetValues(typeof(@enum.RoleName));

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTxt.Text) || string.IsNullOrEmpty(LastNameTxt.Text) || string.IsNullOrEmpty(CellphoneTxt.Text) || string.IsNullOrEmpty(NationalCodeTxt.Text) || string.IsNullOrEmpty(GendercomboBox.Text))
            {

                MessageBox.Show("Please Enter your information ! ");
                return;
            }
            if (IsAdmincheckBox.Checked)
            {
                List<Admin> admins = new List<Admin>();
                Admin Person1 = new Admin();
                Person1.FirstName = FirstNameTxt.Text;
                Person1.LastName = LastNameTxt.Text;
                Person1.Cellphone = CellphoneTxt.Text;
                Person1.NationalCode = NationalCodeTxt.Text;
                Person1.Gender = GendercomboBox.Text;
                Person1.RoleName = RoleNameComboBox.Text;
                Person1.AccessId = AccessIdTxt.Text;
                admins.Add(Person1);
                uint nationalCode = 0;
                if (Person1.NationalCode.Length != 10 || !uint.TryParse(Person1.NationalCode, out nationalCode))
                {
                    MessageBox.Show("Please Enter your NationalCode correctly ! ");
                    return;
                }
                Number_Checking.Number_Replace(Person1.NationalCode);
                Number_Checking.Number_Replace(Person1.Cellphone);
                Number_Checking.Cellphone_Checking(Person1.Cellphone);

            }
            else
            {
                List<User> users = new List<User>();
                User person1 = new User();
                person1.FirstName = FirstNameTxt.Text;
                person1.LastName = LastNameTxt.Text;
                person1.Cellphone = CellphoneTxt.Text;
                person1.NationalCode = NationalCodeTxt.Text;
                person1.Gender = GendercomboBox.Text;
                person1.UserId = UserIdTxt.Text;
                person1.IsAdmin = IsAdmincheckBox.Checked;
                users.Add(person1);
                uint nationalCode = 0;
                if (person1.NationalCode.Length != 10 || !uint.TryParse(person1.NationalCode, out nationalCode))
                {
                    MessageBox.Show("Please Enter your NationalCode correctly ! ");
                    return;
                }
                Number_Checking.Number_Replace(person1.NationalCode);
                Number_Checking.Number_Replace(person1.Cellphone);
                Number_Checking.Cellphone_Checking (person1.Cellphone);

            }
            if (IsAdmincheckBox.Checked && (string.IsNullOrEmpty(AccessIdTxt.Text)) && (string.IsNullOrEmpty(RoleNameComboBox.Text)))
            {
                MessageBox.Show("Please insert your role's information completely");
            }
        }

        private void IsAdmincheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserIdTxt.Enabled =! IsAdmincheckBox.Checked;
            RoleNameComboBox.Enabled = IsAdmincheckBox.Checked;
            AccessIdTxt.Enabled = IsAdmincheckBox.Checked;

        }
    }
}
