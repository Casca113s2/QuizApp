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
    public partial class frmStudentViewGrade : Form
    {
        string userId;
        BLL.StudentViewGradeBLL studentViewGradeBLL;

        public string UserId { get => userId; set => userId = value; }

        public frmStudentViewGrade(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            studentViewGradeBLL = new BLL.StudentViewGradeBLL(this);
        }

        private void frmStudentViewGrade_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            studentViewGradeBLL.loadResultTable();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
