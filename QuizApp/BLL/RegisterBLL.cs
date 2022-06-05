using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.BLL
{
    class RegisterBLL
    {
        DAL.RegisterDAL registerDAL;
        GUI.frmRegister frmRegister;

        public RegisterBLL(GUI.frmRegister frmRegister)
        {
            this.frmRegister = frmRegister;
            registerDAL = new DAL.RegisterDAL();
        }

        public void resetInput()
        {
            //Reset TextBox
            frmRegister.TextBoxUsername.Text = "";
            frmRegister.TextBoxPassword.Text = "";
            frmRegister.TextBoxConfirmPassword.Text = "";
            frmRegister.TextBoxName.Text = "";
            frmRegister.TextBoxAddress.Text = "";
            frmRegister.TextBoxPhone.Text = "";

            //Reset DatePicker
            frmRegister.DateTimePickerBirthDay.Value = DateTime.Now;

            //Reset ComboBox
            frmRegister.ComboBoxType.SelectedIndex = 0;
        }

        private bool validateInputUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || !Regex.Match(username, @"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$").Success
                || (username.Length < 7))
            {
                string message = "Wrong input username. \n" +
                    "Username should not be empty. \n" +
                    "Username length should not be less 6 characters. \n" +
                    "Username should not contain special characters or space.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool validateConfirmPassword(string password, string confirmPassword)
        {
            if (!password.Equals(confirmPassword))
            {
                string message = "Password don't match.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool validateInputPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || !Regex.Match(password, @"(?=^.{6,15}$)(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?!.*\s).*$").Success)
            {
                string message = "Wrong input Password. \n" +
                    "Password should not be empty. \n" +
                    "Between 6 and 15 inclusive, contains atleast one digit, atleast one upper case and atleast one lower case and no whitespace.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool validateInputPhone(string phone)
        {
            if (!string.IsNullOrEmpty(phone))
            {
                bool isNumeric = int.TryParse(phone, out _);

                if(!isNumeric)
                {
                    MessageBox.Show("Wrong input phone number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public void registerUser()
        {
            if (!validateInputUsername(frmRegister.TextBoxUsername.Text)
                || !validateConfirmPassword(frmRegister.TextBoxPassword.Text, frmRegister.TextBoxConfirmPassword.Text)
                || !validateInputPassword(frmRegister.TextBoxPassword.Text)
                || !validateInputPhone(frmRegister.TextBoxPhone.Text))
            {
                Console.WriteLine("Error!");
                return;
            }

            registerDAL.registerUser(frmRegister.TextBoxUsername.Text, EncryptMD5.MD5Hash(frmRegister.TextBoxPassword.Text),
                frmRegister.TextBoxName.Text, frmRegister.DateTimePickerBirthDay.Value, frmRegister.TextBoxAddress.Text,
                frmRegister.TextBoxPhone.Text, frmRegister.ComboBoxType.SelectedItem.ToString());

            resetInput();
        }

        public void closeRegisterFrom(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close register form?", "Close Register", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
