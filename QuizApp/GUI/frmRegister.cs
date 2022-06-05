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
    public partial class frmRegister : Form
    {
        BLL.RegisterBLL registerBLL;
        public frmRegister()
        {
            InitializeComponent();
            registerBLL = new BLL.RegisterBLL(this);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            registerBLL.registerUser();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            registerBLL.resetInput();
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            registerBLL.closeRegisterFrom(e);
        }
    }
}
