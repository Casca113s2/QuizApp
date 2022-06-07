
using System.Windows.Forms;

namespace QuizApp.GUI
{
    partial class frmStudentHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentHome));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.buttonDoTest = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(12, 19);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(184, 42);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "QUIZAPP";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(135)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(790, 80);
            this.panelTitleBar.TabIndex = 9;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(339, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(110, 42);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Home";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(220, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(790, 681);
            this.panelMain.TabIndex = 10;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonLearn);
            this.panelMenu.Controls.Add(this.buttonDoTest);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 761);
            this.panelMenu.TabIndex = 8;
            // 
            // buttonLearn
            // 
            this.buttonLearn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLearn.FlatAppearance.BorderSize = 0;
            this.buttonLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLearn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLearn.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLearn.Image = global::QuizApp.Properties.Resources.pi;
            this.buttonLearn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLearn.Location = new System.Drawing.Point(0, 140);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonLearn.Size = new System.Drawing.Size(220, 60);
            this.buttonLearn.TabIndex = 5;
            this.buttonLearn.Text = "    Learn";
            this.buttonLearn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLearn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLearn.UseVisualStyleBackColor = true;
            this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
            // 
            // buttonDoTest
            // 
            this.buttonDoTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDoTest.FlatAppearance.BorderSize = 0;
            this.buttonDoTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoTest.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoTest.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDoTest.Image = global::QuizApp.Properties.Resources.sigma;
            this.buttonDoTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDoTest.Location = new System.Drawing.Point(0, 80);
            this.buttonDoTest.Name = "buttonDoTest";
            this.buttonDoTest.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonDoTest.Size = new System.Drawing.Size(220, 60);
            this.buttonDoTest.TabIndex = 4;
            this.buttonDoTest.Text = "     Do Test";
            this.buttonDoTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDoTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDoTest.UseVisualStyleBackColor = true;
            this.buttonDoTest.Click += new System.EventHandler(this.buttonDoTest_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 701);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(220, 60);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "    Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // frmStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1010, 761);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.Name = "frmStudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStudentHome_FormClosing);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.Button buttonDoTest;
        private System.Windows.Forms.Button buttonExit;

        public Panel PanelLogo { get => panelLogo; set => panelLogo = value; }
        public Label LabelLogo { get => labelLogo; set => labelLogo = value; }
        public Panel PanelTitleBar { get => panelTitleBar; set => panelTitleBar = value; }
        public Label LabelTitle { get => labelTitle; set => labelTitle = value; }
        public Panel PanelMain { get => panelMain; set => panelMain = value; }
        public Panel PanelMenu { get => panelMenu; set => panelMenu = value; }
        public Button ButtonLearn { get => buttonLearn; set => buttonLearn = value; }
        public Button ButtonDoTest { get => buttonDoTest; set => buttonDoTest = value; }
        public Button ButtonExit { get => buttonExit; set => buttonExit = value; }
    }
}