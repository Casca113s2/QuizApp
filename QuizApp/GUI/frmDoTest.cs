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
    public partial class frmDoTest : Form
    {
        string userId;
        BLL.DoTestBLL doTestBLL;

        public string UserId { get => userId; set => userId = value; }

        public frmDoTest(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            doTestBLL = new BLL.DoTestBLL(this);
        }


        private void frmDoTest_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void buttonLoadTestSet_Click(object sender, EventArgs e)
        {
            doTestBLL.loadTestSet();
        }

        private void timerTestTime_Tick(object sender, EventArgs e)
        {
            doTestBLL.timerTick();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            doTestBLL.nextQuestion();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            doTestBLL.previousQuestion();
        }

        private void radioButtonAnswerA_CheckedChanged(object sender, EventArgs e)
        {
            doTestBLL.ratioButtionChecked(sender, "A");
        }

        private void radioButtonAnswerB_CheckedChanged(object sender, EventArgs e)
        {
            doTestBLL.ratioButtionChecked(sender, "B");
        }

        private void radioButtonAnswerC_CheckedChanged(object sender, EventArgs e)
        {
            doTestBLL.ratioButtionChecked(sender, "C");
        }

        private void radioButtonAnswerD_CheckedChanged(object sender, EventArgs e)
        {
            doTestBLL.ratioButtionChecked(sender, "D");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            doTestBLL.submitButtonClick();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            doTestBLL.resetButtonClick();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            doTestBLL.closeDoTestEditForm();
        }
    }
}
