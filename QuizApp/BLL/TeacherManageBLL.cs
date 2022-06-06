using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.BLL
{
    class TeacherManageBLL
    {
        DAL.TeacherManageDAL teacherManageDAL;
        GUI.frmTeacherManage frmTeacherManage;

        public TeacherManageBLL(GUI.frmTeacherManage frmTeacherManage)
        {
            this.frmTeacherManage = frmTeacherManage;
            teacherManageDAL = new DAL.TeacherManageDAL();
        }

        public void closeTeacherManageForm()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form?", "Close Manage Test Set Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                frmTeacherManage.Close();
        }

        public void loadTestSetTable()
        {
            frmTeacherManage.DataGridViewTestSet.DataSource = teacherManageDAL.loadTestSetData(frmTeacherManage.UserId);
        }

        public void resetField()
        {
            frmTeacherManage.TextBoxTestSetCode.Text = "";
            frmTeacherManage.TextBoxTestSetName.Text = "";
            frmTeacherManage.TextBoxTestSetTime.Text = "";
            frmTeacherManage.TextBoxTestSetCreator.Text = "";

            loadTestSetTable();
            loadQuestionTable("");
        }

        private void loadQuestionTable(string code)
        {
            frmTeacherManage.DataGridViewQuestions.DataSource = teacherManageDAL.loadQuestionsData(code);
        }

        public void clickCell()
        {
            frmTeacherManage.TextBoxTestSetCode.Text = frmTeacherManage.DataGridViewTestSet.CurrentRow.Cells["TESTSETCODE"].Value.ToString();
            frmTeacherManage.TextBoxTestSetName.Text = frmTeacherManage.DataGridViewTestSet.CurrentRow.Cells["TESTSETNAME"].Value.ToString();
            frmTeacherManage.TextBoxTestSetTime.Text = frmTeacherManage.DataGridViewTestSet.CurrentRow.Cells["TIME"].Value.ToString();
            frmTeacherManage.TextBoxTestSetCreator.Text = frmTeacherManage.DataGridViewTestSet.CurrentRow.Cells["TESTSETCREATOR"].Value.ToString();

            loadQuestionTable(frmTeacherManage.TextBoxTestSetCode.Text);
        }

        public bool checkEmptyField()
        {
            if (string.IsNullOrEmpty(frmTeacherManage.TextBoxTestSetCode.Text)
                || string.IsNullOrEmpty(frmTeacherManage.TextBoxTestSetName.Text)
                || string.IsNullOrEmpty(frmTeacherManage.TextBoxTestSetTime.Text)
                || string.IsNullOrEmpty(frmTeacherManage.TextBoxTestSetCreator.Text))
            {
                string message = "You can not leave an empty field when update a test set.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private bool checkExistTestSet(string testCode)
        {
            if (teacherManageDAL.checkExistTestSet(testCode) >= 1)
            {
                string message = "Test set code already exist.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;
            }

            return false;
        }

        private bool checkNotExistTestSet(string testCode)
        {
            if (teacherManageDAL.checkExistTestSet(testCode) < 1)
            {
                string message = "Test set not exist.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;
            }

            return false;
        }

        public void updateTestSet()
        {
            if(!checkEmptyField() 
                && frmTeacherManage.TextBoxTestSetCode.Text.Equals(frmTeacherManage.DataGridViewTestSet.CurrentRow.Cells["TESTSETCODE"].Value.ToString()))
            {
                if(teacherManageDAL.updateTestSetSameKey(
                    frmTeacherManage.TextBoxTestSetCode.Text,
                    frmTeacherManage.TextBoxTestSetName.Text,
                    frmTeacherManage.TextBoxTestSetTime.Text,
                    frmTeacherManage.TextBoxTestSetCreator.Text))
                {
                    resetField();
                }
            }
            else if (!checkEmptyField() && !checkExistTestSet(frmTeacherManage.TextBoxTestSetCode.Text))
            {
                if (teacherManageDAL.updateTestSetDifferentKey(
                    frmTeacherManage.TextBoxTestSetCode.Text,
                    frmTeacherManage.DataGridViewTestSet.CurrentRow.Cells["TESTSETCODE"].Value.ToString(),
                    frmTeacherManage.TextBoxTestSetName.Text,
                    frmTeacherManage.TextBoxTestSetTime.Text,
                    frmTeacherManage.TextBoxTestSetCreator.Text))
                {
                    MessageBox.Show("Update Test Set Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetField();
                }
                else
                {
                    MessageBox.Show("Update Test Set Fail.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resetField();
                }
            }
        }

        public void deleteTestSet()
        {
            if (!string.IsNullOrEmpty(frmTeacherManage.TextBoxTestSetCode.Text) 
                && !checkNotExistTestSet(frmTeacherManage.TextBoxTestSetCode.Text))
            {
                if (teacherManageDAL.deleteTestSet(frmTeacherManage.TextBoxTestSetCode.Text))
                {
                    MessageBox.Show("Delete Test Set Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetField();
                }
                else
                {
                    MessageBox.Show("Delete Test Set Fail.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resetField();
                }
            }
        }

    }
}
