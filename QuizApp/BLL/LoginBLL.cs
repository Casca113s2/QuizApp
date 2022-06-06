using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.BLL
{
    class LoginBLL
    {
        DAL.LoginDAL loginDAL;
        GUI.frmLogin frmLogin;

        public LoginBLL(GUI.frmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            loginDAL = new DAL.LoginDAL();
        }

        public void loadRegisterForm()
        {
            GUI.frmRegister frmRegister = new GUI.frmRegister();
            frmRegister.Closed += (s, agrs) => frmLogin.Show();
            frmLogin.Hide();
            frmRegister.Show();
        }

        public void login()
        {
            if (loginDAL.login(frmLogin.TextBoxUsername.Text, EncryptMD5.MD5Hash(frmLogin.TextBoxPassword.Text)) >= 1)
            {
                GUI.frmTeacherHome frmTeacherHome = new GUI.frmTeacherHome(frmLogin.TextBoxUsername.Text);
                frmTeacherHome.Closed += (s, args) => frmLogin.Close();
                frmLogin.Hide();
                frmTeacherHome.Show();
            }
            else MessageBox.Show("Wrong username or password.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
