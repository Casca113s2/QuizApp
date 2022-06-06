using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.BLL
{
    class TeacherHomeBLL
    {
        private Button currentButton;
        string currentForm;
        private Random random;
        private int tempIndex;
        GUI.frmTeacherHome frmTeacherHome;

        public TeacherHomeBLL(GUI.frmTeacherHome frmTeacherHome)
        {
            random = new Random();
            this.frmTeacherHome = frmTeacherHome;
            currentForm = "";
        }

        private Color SelectedThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];

            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectedThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    frmTeacherHome.PanelTitleBar.BackColor = color;
                    frmTeacherHome.PanelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in frmTeacherHome.PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void deletePanelControls()
        {
            currentForm = "";

            foreach (Control c in frmTeacherHome.PanelMain.Controls)
                c.Dispose();
        }

        public void actionButtonClick(object sender, Form targetForm)
        {
            FormCollection fc = Application.OpenForms;

            bool createForm = true;
            bool openForm = false;

            foreach (Form frm in fc)
            {
                if (frm.Name == currentForm)
                {
                    openForm = true;
                    break;
                }
            }

            if(openForm && (targetForm.Name != currentForm))
            {
                DialogResult dr = MessageBox.Show("Are you sure want to close the current form?", "Close form", MessageBoxButtons.YesNo);

                if (dr == DialogResult.No)
                {
                    targetForm.Dispose();
                    createForm = false;
                }
            }

            if (createForm)
            {
                deletePanelControls();

                frmTeacherHome.LabelTitle.Text = targetForm.Text;
                targetForm.Closed += (s, args) =>
                {
                    currentForm = "";
                    frmTeacherHome.LabelTitle.Text = "Home";
                    frmTeacherHome.PanelMain.Controls.Clear();
                    DisableButton();
                };

                currentForm = targetForm.Name;
                targetForm.TopLevel = false;
                targetForm.Dock = DockStyle.Fill;
                frmTeacherHome.PanelMain.Controls.Add(targetForm);
                targetForm.Show();

                ActivateButton(sender);
            }
        }

        public void closeTeacherHomeFrom(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close register form?", "Close Register", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
