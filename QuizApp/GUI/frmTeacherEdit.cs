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
    public partial class frmTeacherEdit : Form
    {
        string userId;
        BLL.TeacherEditBLL teacherEdit;

        public string UserId { get => userId; set => userId = value; }

        public frmTeacherEdit(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            teacherEdit = new BLL.TeacherEditBLL(this);
        }

        private void frmTeacherEdit_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void buttonLoadTestSet_Click(object sender, EventArgs e)
        {
            teacherEdit.loadTestSet();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            teacherEdit.closeTeacherEditForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            teacherEdit.addQuestion();
        }

        private void buttonDetele_Click(object sender, EventArgs e)
        {
            teacherEdit.deleteQuestion();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            teacherEdit.updateQuestion();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            teacherEdit.resetField();
        }

        private void dataGridViewQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherEdit.clickCell();
        }
    }
}
