
using System.Windows.Forms;

namespace QuizApp.GUI
{
    partial class frmDoTest
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
            this.components = new System.ComponentModel.Container();
            this.panelCreateQuestion = new System.Windows.Forms.Panel();
            this.groupBoxAnswers = new System.Windows.Forms.GroupBox();
            this.radioButtonAnswerC = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswerD = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswerB = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswerA = new System.Windows.Forms.RadioButton();
            this.richTextBoxAnswerD = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAnswerB = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAnswerC = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAnswerA = new System.Windows.Forms.RichTextBox();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTestTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadTestSet = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxTestCode = new System.Windows.Forms.TextBox();
            this.labelCreateTest = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.timerTestTime = new System.Windows.Forms.Timer(this.components);
            this.panelCreateQuestion.SuspendLayout();
            this.groupBoxAnswers.SuspendLayout();
            this.groupBoxQuestion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateQuestion
            // 
            this.panelCreateQuestion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCreateQuestion.Controls.Add(this.groupBoxAnswers);
            this.panelCreateQuestion.Controls.Add(this.groupBoxQuestion);
            this.panelCreateQuestion.Controls.Add(this.buttonReset);
            this.panelCreateQuestion.Controls.Add(this.buttonNext);
            this.panelCreateQuestion.Controls.Add(this.buttonPrevious);
            this.panelCreateQuestion.Controls.Add(this.buttonSubmit);
            this.panelCreateQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreateQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelCreateQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.panelCreateQuestion.Name = "panelCreateQuestion";
            this.panelCreateQuestion.Size = new System.Drawing.Size(810, 541);
            this.panelCreateQuestion.TabIndex = 49;
            this.panelCreateQuestion.Visible = false;
            // 
            // groupBoxAnswers
            // 
            this.groupBoxAnswers.Controls.Add(this.radioButtonAnswerC);
            this.groupBoxAnswers.Controls.Add(this.radioButtonAnswerD);
            this.groupBoxAnswers.Controls.Add(this.radioButtonAnswerB);
            this.groupBoxAnswers.Controls.Add(this.radioButtonAnswerA);
            this.groupBoxAnswers.Controls.Add(this.richTextBoxAnswerD);
            this.groupBoxAnswers.Controls.Add(this.richTextBoxAnswerB);
            this.groupBoxAnswers.Controls.Add(this.richTextBoxAnswerC);
            this.groupBoxAnswers.Controls.Add(this.richTextBoxAnswerA);
            this.groupBoxAnswers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnswers.Location = new System.Drawing.Point(38, 175);
            this.groupBoxAnswers.Name = "groupBoxAnswers";
            this.groupBoxAnswers.Size = new System.Drawing.Size(732, 276);
            this.groupBoxAnswers.TabIndex = 45;
            this.groupBoxAnswers.TabStop = false;
            this.groupBoxAnswers.Text = "Answers";
            // 
            // radioButtonAnswerC
            // 
            this.radioButtonAnswerC.AutoSize = true;
            this.radioButtonAnswerC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswerC.Location = new System.Drawing.Point(22, 175);
            this.radioButtonAnswerC.Name = "radioButtonAnswerC";
            this.radioButtonAnswerC.Size = new System.Drawing.Size(42, 23);
            this.radioButtonAnswerC.TabIndex = 2;
            this.radioButtonAnswerC.TabStop = true;
            this.radioButtonAnswerC.Text = "C.";
            this.radioButtonAnswerC.UseVisualStyleBackColor = true;
            this.radioButtonAnswerC.CheckedChanged += new System.EventHandler(this.radioButtonAnswerC_CheckedChanged);
            // 
            // radioButtonAnswerD
            // 
            this.radioButtonAnswerD.AutoSize = true;
            this.radioButtonAnswerD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswerD.Location = new System.Drawing.Point(404, 175);
            this.radioButtonAnswerD.Name = "radioButtonAnswerD";
            this.radioButtonAnswerD.Size = new System.Drawing.Size(42, 23);
            this.radioButtonAnswerD.TabIndex = 3;
            this.radioButtonAnswerD.TabStop = true;
            this.radioButtonAnswerD.Text = "D.";
            this.radioButtonAnswerD.UseVisualStyleBackColor = true;
            this.radioButtonAnswerD.CheckedChanged += new System.EventHandler(this.radioButtonAnswerD_CheckedChanged);
            // 
            // radioButtonAnswerB
            // 
            this.radioButtonAnswerB.AutoSize = true;
            this.radioButtonAnswerB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswerB.Location = new System.Drawing.Point(404, 67);
            this.radioButtonAnswerB.Name = "radioButtonAnswerB";
            this.radioButtonAnswerB.Size = new System.Drawing.Size(41, 23);
            this.radioButtonAnswerB.TabIndex = 1;
            this.radioButtonAnswerB.TabStop = true;
            this.radioButtonAnswerB.Text = "B.";
            this.radioButtonAnswerB.UseVisualStyleBackColor = true;
            this.radioButtonAnswerB.CheckedChanged += new System.EventHandler(this.radioButtonAnswerB_CheckedChanged);
            // 
            // radioButtonAnswerA
            // 
            this.radioButtonAnswerA.AutoSize = true;
            this.radioButtonAnswerA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswerA.Location = new System.Drawing.Point(22, 67);
            this.radioButtonAnswerA.Name = "radioButtonAnswerA";
            this.radioButtonAnswerA.Size = new System.Drawing.Size(42, 23);
            this.radioButtonAnswerA.TabIndex = 0;
            this.radioButtonAnswerA.TabStop = true;
            this.radioButtonAnswerA.Text = "A.";
            this.radioButtonAnswerA.UseVisualStyleBackColor = true;
            this.radioButtonAnswerA.CheckedChanged += new System.EventHandler(this.radioButtonAnswerA_CheckedChanged);
            // 
            // richTextBoxAnswerD
            // 
            this.richTextBoxAnswerD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAnswerD.Location = new System.Drawing.Point(451, 174);
            this.richTextBoxAnswerD.Name = "richTextBoxAnswerD";
            this.richTextBoxAnswerD.ReadOnly = true;
            this.richTextBoxAnswerD.Size = new System.Drawing.Size(257, 57);
            this.richTextBoxAnswerD.TabIndex = 3;
            this.richTextBoxAnswerD.Text = "";
            // 
            // richTextBoxAnswerB
            // 
            this.richTextBoxAnswerB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAnswerB.Location = new System.Drawing.Point(451, 66);
            this.richTextBoxAnswerB.Name = "richTextBoxAnswerB";
            this.richTextBoxAnswerB.ReadOnly = true;
            this.richTextBoxAnswerB.Size = new System.Drawing.Size(257, 57);
            this.richTextBoxAnswerB.TabIndex = 2;
            this.richTextBoxAnswerB.Text = "";
            // 
            // richTextBoxAnswerC
            // 
            this.richTextBoxAnswerC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAnswerC.Location = new System.Drawing.Point(70, 174);
            this.richTextBoxAnswerC.Name = "richTextBoxAnswerC";
            this.richTextBoxAnswerC.ReadOnly = true;
            this.richTextBoxAnswerC.Size = new System.Drawing.Size(257, 57);
            this.richTextBoxAnswerC.TabIndex = 1;
            this.richTextBoxAnswerC.Text = "";
            // 
            // richTextBoxAnswerA
            // 
            this.richTextBoxAnswerA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAnswerA.Location = new System.Drawing.Point(70, 66);
            this.richTextBoxAnswerA.Name = "richTextBoxAnswerA";
            this.richTextBoxAnswerA.ReadOnly = true;
            this.richTextBoxAnswerA.Size = new System.Drawing.Size(257, 57);
            this.richTextBoxAnswerA.TabIndex = 0;
            this.richTextBoxAnswerA.Text = "";
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.richTextBoxQuestion);
            this.groupBoxQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQuestion.Location = new System.Drawing.Point(38, 12);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Size = new System.Drawing.Size(732, 146);
            this.groupBoxQuestion.TabIndex = 44;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Question";
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxQuestion.Location = new System.Drawing.Point(22, 25);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.ReadOnly = true;
            this.richTextBoxQuestion.Size = new System.Drawing.Size(686, 105);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.Text = "";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(117, 484);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 32);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNext.Enabled = false;
            this.buttonNext.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(426, 484);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(117, 32);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPrevious.Enabled = false;
            this.buttonPrevious.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.White;
            this.buttonPrevious.Location = new System.Drawing.Point(271, 484);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(117, 32);
            this.buttonPrevious.TabIndex = 5;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(578, 484);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(117, 32);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.textBoxTestTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonLoadTestSet);
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.textBoxTestCode);
            this.panel2.Controls.Add(this.labelCreateTest);
            this.panel2.Controls.Add(this.label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 142);
            this.panel2.TabIndex = 48;
            // 
            // textBoxTestTime
            // 
            this.textBoxTestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestTime.Location = new System.Drawing.Point(117, 40);
            this.textBoxTestTime.Name = "textBoxTestTime";
            this.textBoxTestTime.ReadOnly = true;
            this.textBoxTestTime.Size = new System.Drawing.Size(135, 20);
            this.textBoxTestTime.TabIndex = 27;
            this.textBoxTestTime.Text = "00:00:00";
            this.textBoxTestTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Test Time";
            // 
            // buttonLoadTestSet
            // 
            this.buttonLoadTestSet.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonLoadTestSet.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonLoadTestSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTestSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadTestSet.ForeColor = System.Drawing.Color.White;
            this.buttonLoadTestSet.Location = new System.Drawing.Point(426, 87);
            this.buttonLoadTestSet.Name = "buttonLoadTestSet";
            this.buttonLoadTestSet.Size = new System.Drawing.Size(117, 32);
            this.buttonLoadTestSet.TabIndex = 25;
            this.buttonLoadTestSet.Text = "Load Test Set";
            this.buttonLoadTestSet.UseVisualStyleBackColor = false;
            this.buttonLoadTestSet.Click += new System.EventHandler(this.buttonLoadTestSet_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(578, 87);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 32);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxTestCode
            // 
            this.textBoxTestCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestCode.Location = new System.Drawing.Point(501, 40);
            this.textBoxTestCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTestCode.Name = "textBoxTestCode";
            this.textBoxTestCode.Size = new System.Drawing.Size(194, 20);
            this.textBoxTestCode.TabIndex = 23;
            // 
            // labelCreateTest
            // 
            this.labelCreateTest.AutoSize = true;
            this.labelCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateTest.Location = new System.Drawing.Point(423, 15);
            this.labelCreateTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateTest.Name = "labelCreateTest";
            this.labelCreateTest.Size = new System.Drawing.Size(96, 13);
            this.labelCreateTest.TabIndex = 9;
            this.labelCreateTest.Text = "Create Test Set";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(423, 43);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Test set code";
            // 
            // timerTestTime
            // 
            this.timerTestTime.Interval = 1000;
            this.timerTestTime.Tick += new System.EventHandler(this.timerTestTime_Tick);
            // 
            // frmDoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 683);
            this.Controls.Add(this.panelCreateQuestion);
            this.Controls.Add(this.panel2);
            this.Name = "frmDoTest";
            this.Text = "Do Test";
            this.Load += new System.EventHandler(this.frmDoTest_Load);
            this.panelCreateQuestion.ResumeLayout(false);
            this.groupBoxAnswers.ResumeLayout(false);
            this.groupBoxAnswers.PerformLayout();
            this.groupBoxQuestion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateQuestion;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLoadTestSet;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxTestCode;
        private System.Windows.Forms.Label labelCreateTest;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.GroupBox groupBoxAnswers;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerD;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerB;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerC;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerA;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.RadioButton radioButtonAnswerA;
        private System.Windows.Forms.RadioButton radioButtonAnswerC;
        private System.Windows.Forms.RadioButton radioButtonAnswerD;
        private System.Windows.Forms.RadioButton radioButtonAnswerB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTestTime;
        private Timer timerTestTime;

        public Panel PanelCreateQuestion { get => panelCreateQuestion; set => panelCreateQuestion = value; }
        public Button ButtonPrevious { get => buttonPrevious; set => buttonPrevious = value; }
        public Button ButtonSubmit { get => buttonSubmit; set => buttonSubmit = value; }
        public Panel Panel2 { get => panel2; set => panel2 = value; }
        public Button ButtonLoadTestSet { get => buttonLoadTestSet; set => buttonLoadTestSet = value; }
        public Button ButtonBack { get => buttonBack; set => buttonBack = value; }
        public TextBox TextBoxTestCode { get => textBoxTestCode; set => textBoxTestCode = value; }
        public Label LabelCreateTest { get => labelCreateTest; set => labelCreateTest = value; }
        public Label Label { get => label; set => label = value; }
        public Button ButtonReset { get => buttonReset; set => buttonReset = value; }
        public Button ButtonNext { get => buttonNext; set => buttonNext = value; }
        public GroupBox GroupBoxAnswers { get => groupBoxAnswers; set => groupBoxAnswers = value; }
        public RichTextBox RichTextBoxAnswerD { get => richTextBoxAnswerD; set => richTextBoxAnswerD = value; }
        public RichTextBox RichTextBoxAnswerB { get => richTextBoxAnswerB; set => richTextBoxAnswerB = value; }
        public RichTextBox RichTextBoxAnswerC { get => richTextBoxAnswerC; set => richTextBoxAnswerC = value; }
        public RichTextBox RichTextBoxAnswerA { get => richTextBoxAnswerA; set => richTextBoxAnswerA = value; }
        public GroupBox GroupBoxQuestion { get => groupBoxQuestion; set => groupBoxQuestion = value; }
        public RichTextBox RichTextBoxQuestion { get => richTextBoxQuestion; set => richTextBoxQuestion = value; }
        public RadioButton RadioButtonAnswerA { get => radioButtonAnswerA; set => radioButtonAnswerA = value; }
        public RadioButton RadioButtonAnswerC { get => radioButtonAnswerC; set => radioButtonAnswerC = value; }
        public RadioButton RadioButtonAnswerD { get => radioButtonAnswerD; set => radioButtonAnswerD = value; }
        public RadioButton RadioButtonAnswerB { get => radioButtonAnswerB; set => radioButtonAnswerB = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TextBoxTestTime { get => textBoxTestTime; set => textBoxTestTime = value; }
        public Timer TimerTestTime { get => timerTestTime; set => timerTestTime = value; }
    }
}