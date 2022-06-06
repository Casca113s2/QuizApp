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
    public partial class frmTeacherHome : Form
    {
        BLL.TeacherHomeBLL TeacherHomeBLL;
        string userId;

        public frmTeacherHome(string userID)
        {
            InitializeComponent();
            TeacherHomeBLL = new BLL.TeacherHomeBLL(this);
            this.userId = userID;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            TeacherHomeBLL.actionButtonClick(sender, new frmTeacherNew(userId));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            TeacherHomeBLL.actionButtonClick(sender, new frmTeacherEdit(userId));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTeacherHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            TeacherHomeBLL.closeTeacherHomeFrom(e);
        }
    }
}
