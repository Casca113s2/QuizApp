
using System.Windows.Forms;

namespace QuizApp.GUI
{
    partial class frmTeacherHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherHome));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonManage = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(135)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(790, 80);
            this.panelTitleBar.TabIndex = 6;
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
            this.panelMain.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonManage);
            this.panelMenu.Controls.Add(this.buttonEdit);
            this.panelMenu.Controls.Add(this.buttonNew);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 761);
            this.panelMenu.TabIndex = 5;
            // 
            // buttonManage
            // 
            this.buttonManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManage.FlatAppearance.BorderSize = 0;
            this.buttonManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonManage.Image = global::QuizApp.Properties.Resources.manual;
            this.buttonManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManage.Location = new System.Drawing.Point(0, 200);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonManage.Size = new System.Drawing.Size(220, 60);
            this.buttonManage.TabIndex = 6;
            this.buttonManage.Text = "  Manage";
            this.buttonManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonManage.UseVisualStyleBackColor = true;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEdit.Image = global::QuizApp.Properties.Resources.pi;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(0, 140);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonEdit.Size = new System.Drawing.Size(220, 60);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "    Edit Test Set";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNew.Image = global::QuizApp.Properties.Resources.sigma;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(0, 80);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonNew.Size = new System.Drawing.Size(220, 60);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "     New Test Set";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
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
            // frmTeacherHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1010, 761);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.Name = "frmTeacherHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeacherHome_FormClosing);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private Button buttonManage;

        public Panel PanelTitleBar { get => panelTitleBar; set => panelTitleBar = value; }
        public Label LabelTitle { get => labelTitle; set => labelTitle = value; }
        public Panel PanelMain { get => panelMain; set => panelMain = value; }
        public Panel PanelMenu { get => panelMenu; set => panelMenu = value; }
        public Button ButtonExit { get => buttonExit; set => buttonExit = value; }
        public Panel PanelLogo { get => panelLogo; set => panelLogo = value; }
        public Label LabelLogo { get => labelLogo; set => labelLogo = value; }
        public Button ButtonNew { get => buttonNew; set => buttonNew = value; }
        public Button ButtonEdit { get => buttonEdit; set => buttonEdit = value; }
    }
}