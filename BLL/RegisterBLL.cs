using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
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
            frmRegister.TextBoxName.Text = "";
            frmRegister.TextBoxAddress.Text = "";
            frmRegister.TextBoxPhone.Text = "";

            //Reset DatePicker
            frmRegister.DateTimePickerBirthDay.Value = DateTime.Now;

            //Reset ComboBox
            frmRegister.ComboBoxType.SelectedIndex = 0;
        }

        public void registerUser()
        {
            registerDAL.registerUser(frmRegister.TextBoxUsername.Text, frmRegister.TextBoxPassword.Text, 
                frmRegister.TextBoxName.Text, frmRegister.DateTimePickerBirthDay.Value, frmRegister.TextBoxAddress.Text,
                frmRegister.TextBoxPhone.Text, frmRegister.ComboBoxType.SelectedItem.ToString());

            resetInput();
        }
    }
}
