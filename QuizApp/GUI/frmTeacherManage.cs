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
    public partial class frmTeacherManage : Form
    {
        string userId;
        BLL.TeacherManageBLL teacherManageBLL;

        public string UserId { get => userId; set => userId = value; }

        public frmTeacherManage(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            teacherManageBLL = new BLL.TeacherManageBLL(this);
        }

        private void frmTeacherManage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            teacherManageBLL.loadTestSetTable();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            teacherManageBLL.closeTeacherManageForm();
        }

        private void buttonDetele_Click(object sender, EventArgs e)
        {
            teacherManageBLL.deleteTestSet();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            teacherManageBLL.updateTestSet();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            teacherManageBLL.resetField();
        }

        private void dataGridViewTestSet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherManageBLL.clickCell();
        }
    }
}
