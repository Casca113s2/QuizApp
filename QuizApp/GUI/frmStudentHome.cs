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
    public partial class frmStudentHome : Form
    {
        string userId;
        BLL.StudentHomeBLL studentHomeBLL;

        public string UserId { get => userId; set => userId = value; }

        public frmStudentHome(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            studentHomeBLL = new BLL.StudentHomeBLL(this);
        }

        private void buttonDoTest_Click(object sender, EventArgs e)
        {
            studentHomeBLL.actionButtonClick(sender, new frmDoTest(UserId));
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStudentHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            studentHomeBLL.closeStudentHomeFrom(e);
        }
    }
}
