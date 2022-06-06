using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.BLL
{
    class TeacherNewBLL
    {
        DAL.TeacherNewDAL teacherNewDAL;
        GUI.frmTeacherNew frmTeacherNew;

        public TeacherNewBLL(GUI.frmTeacherNew frmTeacherNew)
        {
            this.frmTeacherNew = frmTeacherNew;
            teacherNewDAL = new DAL.TeacherNewDAL();
        }

        public bool checkEmptyFieldTestSet()
        {
            if(string.IsNullOrEmpty(frmTeacherNew.TextBoxTestCode.Text) || string.IsNullOrEmpty(frmTeacherNew.TextBoxTestName.Text) )
            {
                string message = "Test code or test name is empty.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public void loadQuestionData()
        {
           frmTeacherNew.DataGridViewQuestions.DataSource = teacherNewDAL.loadQuestionData(frmTeacherNew.TextBoxTestCode.Text);
        }

        public void createTestSet()
        {
            if(!checkEmptyFieldTestSet())
            {
                if(teacherNewDAL.createTestSet(frmTeacherNew.TextBoxTestCode.Text, frmTeacherNew.TextBoxTestName.Text, frmTeacherNew.UserId))
                {
                    frmTeacherNew.TextBoxTestCode.ReadOnly = true;
                    frmTeacherNew.TextBoxTestName.ReadOnly = true;
                    frmTeacherNew.ButtonCreateTest.Enabled = false;

                    frmTeacherNew.PanelCreateQuestion.Visible = true;
                    loadQuestionData();
                }
            }
        }
        
        public void resetField()
        {
            frmTeacherNew.TextBoxId.Text = "";
            frmTeacherNew.RichTextBoxQuestion.Text = "";
            frmTeacherNew.RichTextBoxAnswerA.Text = "";
            frmTeacherNew.RichTextBoxAnswerB.Text = "";
            frmTeacherNew.RichTextBoxAnswerC.Text = "";
            frmTeacherNew.RichTextBoxAnswerD.Text = "";

            frmTeacherNew.ComboBoxRightAnswer.SelectedIndex = 0;
            loadQuestionData();
        }

        public bool checkEmptyFieldQuestion()
        {
            if (string.IsNullOrEmpty(frmTeacherNew.RichTextBoxQuestion.Text) 
                || string.IsNullOrEmpty(frmTeacherNew.RichTextBoxAnswerA.Text)
                || string.IsNullOrEmpty(frmTeacherNew.RichTextBoxAnswerB.Text)
                || string.IsNullOrEmpty(frmTeacherNew.RichTextBoxAnswerC.Text)
                || string.IsNullOrEmpty(frmTeacherNew.RichTextBoxAnswerD.Text)
                || string.IsNullOrEmpty(frmTeacherNew.ComboBoxRightAnswer.Text))
            {
                string message = "You can not leave an empty field when create a question.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public void clickCell()
        {
            frmTeacherNew.TextBoxId.Text = frmTeacherNew.DataGridViewQuestions.CurrentRow.Cells["ID"].Value.ToString();
            frmTeacherNew.RichTextBoxQuestion.Text = frmTeacherNew.DataGridViewQuestions.CurrentRow.Cells["QUESTION"].Value.ToString();
            frmTeacherNew.RichTextBoxAnswerA.Text = frmTeacherNew.DataGridViewQuestions.CurrentRow.Cells["ANSWERA"].Value.ToString();
            frmTeacherNew.RichTextBoxAnswerB.Text = frmTeacherNew.DataGridViewQuestions.CurrentRow.Cells["ANSWERB"].Value.ToString();
            frmTeacherNew.RichTextBoxAnswerC.Text = frmTeacherNew.DataGridViewQuestions.CurrentRow.Cells["ANSWERC"].Value.ToString();
            frmTeacherNew.RichTextBoxAnswerD.Text = frmTeacherNew.DataGridViewQuestions.CurrentRow.Cells["ANSWERD"].Value.ToString();
            frmTeacherNew.ComboBoxRightAnswer.Text = frmTeacherNew.DataGridViewQuestions.CurrentRow.Cells["RIGHTANSWER"].Value.ToString();
        }

        public void addQuestion()
        {
            if (!checkEmptyFieldQuestion())
            {
                if (teacherNewDAL.addQuesiton(
                    frmTeacherNew.RichTextBoxQuestion.Text,
                    frmTeacherNew.RichTextBoxAnswerA.Text,
                    frmTeacherNew.RichTextBoxAnswerB.Text,
                    frmTeacherNew.RichTextBoxAnswerC.Text,
                    frmTeacherNew.RichTextBoxAnswerD.Text,
                    frmTeacherNew.ComboBoxRightAnswer.SelectedItem.ToString(),
                    frmTeacherNew.TextBoxTestCode.Text))
                {
                    resetField();
                }
            }
        }

        public bool checkEmptyFieldId()
        {
            if (string.IsNullOrEmpty(frmTeacherNew.TextBoxId.Text))
            {
                return true;
            }
            return false;
        }

        public void deleteQuestion()
        {
            if(!checkEmptyFieldId())
            {
                if(teacherNewDAL.deleteQuestion(frmTeacherNew.TextBoxId.Text))
                {
                    resetField();
                }
            }
        }

        public void updateQuestion()
        {
            if (!checkEmptyFieldId() || !checkEmptyFieldQuestion())
            {
                if (teacherNewDAL.updateQuestion(
                    frmTeacherNew.TextBoxId.Text,
                    frmTeacherNew.RichTextBoxQuestion.Text,
                    frmTeacherNew.RichTextBoxAnswerA.Text,
                    frmTeacherNew.RichTextBoxAnswerB.Text,
                    frmTeacherNew.RichTextBoxAnswerC.Text,
                    frmTeacherNew.RichTextBoxAnswerD.Text,
                    frmTeacherNew.ComboBoxRightAnswer.SelectedItem.ToString(),
                    frmTeacherNew.TextBoxTestCode.Text))
                {
                    resetField();
                }
            }
        }

        public void closeTeacherNewForm()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form?", "Close Add New Question Set", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                frmTeacherNew.Close();
        }
    }
}
