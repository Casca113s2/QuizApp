using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.BLL
{
    class StudentViewGradeBLL
    {
        DAL.StudentViewGradeDAL studentViewGradeDAL;
        GUI.frmStudentViewGrade frmStudentViewGrade;

        public StudentViewGradeBLL(GUI.frmStudentViewGrade frmStudentViewGrade)
        {
            this.frmStudentViewGrade = frmStudentViewGrade;
            studentViewGradeDAL = new DAL.StudentViewGradeDAL();
        }

        public void loadResultTable()
        {
            frmStudentViewGrade.DataGridViewResult.DataSource = studentViewGradeDAL.loadResultTable(frmStudentViewGrade.UserId);
        }


    }
}
