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
    public partial class frmTeacherNew : Form
    {
        BLL.TeacherNewBLL teacherNewBLL;
        string userId;

        public string UserId { get => userId; set => userId = value; }

        public frmTeacherNew(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            teacherNewBLL = new BLL.TeacherNewBLL(this);
        }

        private void frmTeacherNew_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            teacherNewBLL.closeTeacherNewForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            teacherNewBLL.addQuestion();
        }

        private void buttonCreateTest_Click(object sender, EventArgs e)
        {
            teacherNewBLL.createTestSet();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            teacherNewBLL.resetField();
        }

        private void buttonDetele_Click(object sender, EventArgs e)
        {
            teacherNewBLL.deleteQuestion();
        }

        private void dataGridViewQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherNewBLL.clickCell();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            teacherNewBLL.updateQuestion();
        }

        private void textBoxTestSetTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            teacherNewBLL.timeTextBoxKeyPress(e);
        }
    }
}
