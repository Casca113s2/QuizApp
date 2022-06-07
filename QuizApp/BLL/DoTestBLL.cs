using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.BLL
{
    class DoTestBLL
    {
        DAL.DoTestDAL doTestDAL;
        GUI.frmDoTest frmDoTest;
        int testTime;
        int hour;
        int minute;
        int second;

        DataTable Questions;
        int currentQuestionIndex;

        Dictionary<string, string> userAnswer;

        public DoTestBLL(GUI.frmDoTest frmDoTest)
        {
            this.frmDoTest = frmDoTest;
            doTestDAL = new DAL.DoTestDAL();
            currentQuestionIndex = 0;
            userAnswer = new Dictionary<string, string>();
        }

        public bool checkEmptyFieldTestSet()
        {
            if (string.IsNullOrEmpty(frmDoTest.TextBoxTestCode.Text))
            {
                string message = "Test code is empty.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool checkExistTestSet(string testCode)
        {
            if (doTestDAL.checkExistTestSet(testCode) < 1)
            {
                string message = "Test set does not exist.";

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public void loadQuestion()
        {
            frmDoTest.RadioButtonAnswerA.Checked = false;
            frmDoTest.RadioButtonAnswerB.Checked = false;
            frmDoTest.RadioButtonAnswerC.Checked = false;
            frmDoTest.RadioButtonAnswerD.Checked = false;

            DataRow Question = Questions.Rows[currentQuestionIndex];

            frmDoTest.RichTextBoxQuestion.Text = Question["QUESTION"].ToString();
            frmDoTest.RichTextBoxAnswerA.Text = Question["ANSWERA"].ToString();
            frmDoTest.RichTextBoxAnswerB.Text = Question["ANSWERB"].ToString();
            frmDoTest.RichTextBoxAnswerC.Text = Question["ANSWERC"].ToString();
            frmDoTest.RichTextBoxAnswerD.Text = Question["ANSWERD"].ToString();

        }

        private void loadCheckedRadioButton()
        {
            DataRow Question = Questions.Rows[currentQuestionIndex];

            if(userAnswer[Question["ID"].ToString()].Equals("A"))
            {
                frmDoTest.RadioButtonAnswerA.Checked = true;
            }
            else if (userAnswer[Question["ID"].ToString()].Equals("B"))
            {
                frmDoTest.RadioButtonAnswerB.Checked = true;
            }
            else if (userAnswer[Question["ID"].ToString()].Equals("C"))
            {
                frmDoTest.RadioButtonAnswerC.Checked = true;
            }
            else if (userAnswer[Question["ID"].ToString()].Equals("D"))
            {
                frmDoTest.RadioButtonAnswerD.Checked = true;
            }
        }

        public void nextQuestion()
        {
            currentQuestionIndex++;
            loadQuestion();

            if (currentQuestionIndex > 0)
            {
                frmDoTest.ButtonPrevious.Enabled = true;
            }

            if (currentQuestionIndex == (Questions.Rows.Count - 1))
            {
                frmDoTest.ButtonNext.Enabled = false;
            }

            loadCheckedRadioButton();
        }

        public void previousQuestion()
        {
            currentQuestionIndex--;
            loadQuestion();

            if (currentQuestionIndex < (Questions.Rows.Count - 1))
            {
                frmDoTest.ButtonNext.Enabled = true;   
            }

            if (currentQuestionIndex == 0)
            {
                frmDoTest.ButtonPrevious.Enabled = false;
            }

            loadCheckedRadioButton();
        }

        public void loadQuestionData()
        {
            currentQuestionIndex = 0;
            Questions = doTestDAL.loadQuestionData(frmDoTest.TextBoxTestCode.Text);

            foreach (DataRow dr in Questions.Rows)
            {
                userAnswer.Add(dr["ID"].ToString(), "");
            }
        }

        public void ratioButtionChecked(object sender, string res)
        {
            if(((RadioButton)sender).Checked)
            {
                DataRow Question = Questions.Rows[currentQuestionIndex];
                userAnswer[Question["ID"].ToString()] = res;
            }
        }

        public void resetButtonClick()
        {
            DataRow Question = Questions.Rows[currentQuestionIndex];

            frmDoTest.RadioButtonAnswerA.Checked = false;
            frmDoTest.RadioButtonAnswerB.Checked = false;
            frmDoTest.RadioButtonAnswerC.Checked = false;
            frmDoTest.RadioButtonAnswerD.Checked = false;
            userAnswer[Question["ID"].ToString()] = "";
        }

        private void submit()
        {
            string testCode = frmDoTest.TextBoxTestCode.Text;
            int rightAnswerNum = 0;

            int i = 0;

            resetField();

            foreach (DataRow dr in Questions.Rows)
            {
                if(dr["RIGHTANSWER"].Equals(userAnswer[dr["ID"].ToString()]))
                {
                    rightAnswerNum++;
                }
            }

            string message = "You answer right " + rightAnswerNum + " on " + Questions.Rows.Count + " questions.";

            MessageBox.Show(message, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            float grade = 0;

            if(Questions.Rows.Count > 0)
            {
                grade = (rightAnswerNum * 10) / Questions.Rows.Count;
            }

            doTestDAL.submit(frmDoTest.UserId, testCode, grade.ToString());

            Questions = new DataTable();
            userAnswer = new Dictionary<string, string>();
        }

        public void submitButtonClick()
        {
            submit();
        }

        public void loadTimer()
        {
            string loadTime = doTestDAL.getTestTime(frmDoTest.TextBoxTestCode.Text);
            testTime = int.Parse(loadTime);
            testTime = testTime * 60;

            double time = testTime;

            hour = ((int)(time / 3600));
            time = time / 3600;
            time = time - Math.Floor(time);

            minute = ((int)(time * 60));
            time = time * 60;
            time = time - Math.Floor(time);

            second = ((int)(time * 60));
        }

        public void timerTick()
        {
            string h = "";
            string m = "";
            string s = "";

            if (testTime > 0)
            {
                if (second == 0)
                {
                    second = 60;
                    minute -= 1;
                }

                if(minute == 0 && hour > 0)
                {
                    minute = 60;
                    hour -= 1;
                }

                if(hour < 10)
                {
                    h = "0" + hour;
                }
                else
                {
                    h = hour.ToString();
                }

                if (minute < 10)
                {
                    m = "0" + minute;
                }
                else
                {
                    m = minute.ToString();
                }

                if (second < 10)
                {
                    s = "0" + second;
                }
                else
                {
                    s = second.ToString();
                }

                frmDoTest.TextBoxTestTime.Text = string.Format("{0}:{1}:{2}", h, m, s);

                if(testTime == 60)
                {
                    frmDoTest.TextBoxTestTime.BackColor = Color.Red;
                    frmDoTest.TextBoxTestTime.ForeColor = Color.White;
                }

                testTime -= 1;

                second -= 1;

            }
            else
            {
                MessageBox.Show("The time is up.", "Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                submit();
            }
        }

        public void loadTestSet()
        {
            if (!checkEmptyFieldTestSet())
            {
                if (checkExistTestSet(frmDoTest.TextBoxTestCode.Text))
                {
                    frmDoTest.TextBoxTestCode.ReadOnly = true;
                    frmDoTest.ButtonLoadTestSet.Enabled = false;
                    frmDoTest.PanelCreateQuestion.Visible = true;

                    loadTimer();
                    frmDoTest.TimerTestTime.Start();
                    loadQuestionData();
                    loadQuestion();

                    if((Questions.Rows.Count - 1) > 1)
                    {
                        frmDoTest.ButtonNext.Enabled = true;
                    }
                }
            }
        }

        public void resetField()
        {
            currentQuestionIndex = 0;
            frmDoTest.TextBoxTestTime.BackColor = SystemColors.Control;
            frmDoTest.TextBoxTestTime.ForeColor = SystemColors.ControlText;

            frmDoTest.TextBoxTestTime.Text = "00:00:00";
            frmDoTest.TextBoxTestCode.Text = "";
            frmDoTest.RichTextBoxQuestion.Text = "";
            frmDoTest.RichTextBoxAnswerA.Text = "";
            frmDoTest.RichTextBoxAnswerB.Text = "";
            frmDoTest.RichTextBoxAnswerC.Text = "";
            frmDoTest.RichTextBoxAnswerD.Text = "";
            frmDoTest.RadioButtonAnswerA.Checked = false;
            frmDoTest.RadioButtonAnswerB.Checked = false;
            frmDoTest.RadioButtonAnswerC.Checked = false;
            frmDoTest.RadioButtonAnswerD.Checked = false;

            frmDoTest.ButtonNext.Enabled = false;
            frmDoTest.ButtonPrevious.Enabled = false;

            frmDoTest.TextBoxTestCode.ReadOnly = false;
            frmDoTest.ButtonLoadTestSet.Enabled = true;
            frmDoTest.PanelCreateQuestion.Visible = false;

            frmDoTest.TimerTestTime.Stop();
        }

        public void closeDoTestEditForm()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form?", "Close Edit Question Set Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(frmDoTest.PanelCreateQuestion.Visible)
            {
                submit();
            }

            if (result == DialogResult.Yes)
                frmDoTest.Close();
        }
    }
}
