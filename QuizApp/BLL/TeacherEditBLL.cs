using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.BLL
{
    class TeacherEditBLL
    {
        DAL.TeacherEditDAL teacherEditDAL;
        GUI.frmTeacherEdit frmTeacherEdit;

        public TeacherEditBLL(GUI.frmTeacherEdit frmTeacherEdit)
        {
            this.frmTeacherEdit = frmTeacherEdit;
            teacherEditDAL = new DAL.TeacherEditDAL();
        }

        public bool checkEmptyFieldTestSet()
        {
            if (string.IsNullOrEmpty(frmTeacherEdit.TextBoxTestCode.Text))
            {
                string message = "Test code is empty.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public void loadQuestionData()
        {
            frmTeacherEdit.DataGridViewQuestions.DataSource = teacherEditDAL.loadQuestionData(frmTeacherEdit.TextBoxTestCode.Text);
        }

        private bool checkMatchUserTestSet(string testCode, string userId)
        {
            if (teacherEditDAL.checkMatchUserTestSet(testCode, userId) < 1)
            {
                string message = "You not allow to edit this test set.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private bool checkExistTestSet(string testCode)
        {
            if(teacherEditDAL.checkExistTestSet(testCode) < 1)
            {
                string message = "Test set does not exist.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public void loadTestSet()
        {
            if (!checkEmptyFieldTestSet())
            {
                if (checkExistTestSet(frmTeacherEdit.TextBoxTestCode.Text) && checkMatchUserTestSet(frmTeacherEdit.TextBoxTestCode.Text, frmTeacherEdit.UserId))
                {
                    frmTeacherEdit.TextBoxTestCode.ReadOnly = true;
                    frmTeacherEdit.ButtonLoadTestSet.Enabled = false;

                    frmTeacherEdit.PanelCreateQuestion.Visible = true;
                    loadQuestionData();
                }
            }
        }

        public void resetField()
        {
            frmTeacherEdit.TextBoxId.Text = "";
            frmTeacherEdit.RichTextBoxQuestion.Text = "";
            frmTeacherEdit.RichTextBoxAnswerA.Text = "";
            frmTeacherEdit.RichTextBoxAnswerB.Text = "";
            frmTeacherEdit.RichTextBoxAnswerC.Text = "";
            frmTeacherEdit.RichTextBoxAnswerD.Text = "";

            frmTeacherEdit.ComboBoxRightAnswer.SelectedIndex = 0;
            loadQuestionData();
        }

        public bool checkEmptyFieldQuestion()
        {
            if (string.IsNullOrEmpty(frmTeacherEdit.RichTextBoxQuestion.Text)
                || string.IsNullOrEmpty(frmTeacherEdit.RichTextBoxAnswerA.Text)
                || string.IsNullOrEmpty(frmTeacherEdit.RichTextBoxAnswerB.Text)
                || string.IsNullOrEmpty(frmTeacherEdit.RichTextBoxAnswerC.Text)
                || string.IsNullOrEmpty(frmTeacherEdit.RichTextBoxAnswerD.Text)
                || string.IsNullOrEmpty(frmTeacherEdit.ComboBoxRightAnswer.Text))
            {
                string message = "You can not leave an empty field when create a question.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public void clickCell()
        {
            frmTeacherEdit.TextBoxId.Text = frmTeacherEdit.DataGridViewQuestions.CurrentRow.Cells["ID"].Value.ToString();
            frmTeacherEdit.RichTextBoxQuestion.Text = frmTeacherEdit.DataGridViewQuestions.CurrentRow.Cells["QUESTION"].Value.ToString();
            frmTeacherEdit.RichTextBoxAnswerA.Text = frmTeacherEdit.DataGridViewQuestions.CurrentRow.Cells["ANSWERA"].Value.ToString();
            frmTeacherEdit.RichTextBoxAnswerB.Text = frmTeacherEdit.DataGridViewQuestions.CurrentRow.Cells["ANSWERB"].Value.ToString();
            frmTeacherEdit.RichTextBoxAnswerC.Text = frmTeacherEdit.DataGridViewQuestions.CurrentRow.Cells["ANSWERC"].Value.ToString();
            frmTeacherEdit.RichTextBoxAnswerD.Text = frmTeacherEdit.DataGridViewQuestions.CurrentRow.Cells["ANSWERD"].Value.ToString();
            frmTeacherEdit.ComboBoxRightAnswer.Text = frmTeacherEdit.DataGridViewQuestions.CurrentRow.Cells["RIGHTANSWER"].Value.ToString();
        }

        public void addQuestion()
        {
            if (!checkEmptyFieldQuestion())
            {
                if (teacherEditDAL.addQuesiton(
                    frmTeacherEdit.RichTextBoxQuestion.Text,
                    frmTeacherEdit.RichTextBoxAnswerA.Text,
                    frmTeacherEdit.RichTextBoxAnswerB.Text,
                    frmTeacherEdit.RichTextBoxAnswerC.Text,
                    frmTeacherEdit.RichTextBoxAnswerD.Text,
                    frmTeacherEdit.ComboBoxRightAnswer.SelectedItem.ToString(),
                    frmTeacherEdit.TextBoxTestCode.Text))
                {
                    resetField();
                }
            }
        }

        public bool checkEmptyFieldId()
        {
            if (string.IsNullOrEmpty(frmTeacherEdit.TextBoxId.Text))
            {
                return true;
            }
            return false;
        }

        public void deleteQuestion()
        {
            if (!checkEmptyFieldId())
            {
                if (teacherEditDAL.deleteQuestion(frmTeacherEdit.TextBoxId.Text))
                {
                    resetField();
                }
            }
        }

        public void updateQuestion()
        {
            if (!checkEmptyFieldId() || !checkEmptyFieldQuestion())
            {
                if (teacherEditDAL.updateQuestion(
                    frmTeacherEdit.TextBoxId.Text,
                    frmTeacherEdit.RichTextBoxQuestion.Text,
                    frmTeacherEdit.RichTextBoxAnswerA.Text,
                    frmTeacherEdit.RichTextBoxAnswerB.Text,
                    frmTeacherEdit.RichTextBoxAnswerC.Text,
                    frmTeacherEdit.RichTextBoxAnswerD.Text,
                    frmTeacherEdit.ComboBoxRightAnswer.SelectedItem.ToString(),
                    frmTeacherEdit.TextBoxTestCode.Text))
                {
                    resetField();
                }
            }
        }

        public void closeTeacherEditForm()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form?", "Close Edit Question Set Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                frmTeacherEdit.Close();
        }
    }
}
