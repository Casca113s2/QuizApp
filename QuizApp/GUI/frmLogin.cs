using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.GUI
{
    public partial class frmLogin : Form
    {
        BLL.LoginBLL loginBLL;

        public frmLogin()
        {
            InitializeComponent();
            loginBLL = new BLL.LoginBLL(this);

            //Test code
            this.textBoxUsername.Text = "vancleca1";
            this.textBoxPassword.Text = "Casca113s2@";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginBLL.loadRegisterForm();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            loginBLL.login();
        }
    }
}
