
using System.Windows.Forms;

namespace QuizApp.GUI
{
    partial class frmTeacherEdit
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
            this.panelCreateQuestion = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDetele = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.comboBoxRightAnswer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxAnswerD = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxAnswerC = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxAnswerB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxAnswerA = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLoadTestSet = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxTestCode = new System.Windows.Forms.TextBox();
            this.labelCreateTest = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panelCreateQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateQuestion
            // 
            this.panelCreateQuestion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCreateQuestion.Controls.Add(this.label9);
            this.panelCreateQuestion.Controls.Add(this.textBoxId);
            this.panelCreateQuestion.Controls.Add(this.buttonReset);
            this.panelCreateQuestion.Controls.Add(this.buttonUpdate);
            this.panelCreateQuestion.Controls.Add(this.buttonDetele);
            this.panelCreateQuestion.Controls.Add(this.buttonAdd);
            this.panelCreateQuestion.Controls.Add(this.label8);
            this.panelCreateQuestion.Controls.Add(this.dataGridViewQuestions);
            this.panelCreateQuestion.Controls.Add(this.comboBoxRightAnswer);
            this.panelCreateQuestion.Controls.Add(this.label7);
            this.panelCreateQuestion.Controls.Add(this.richTextBoxAnswerD);
            this.panelCreateQuestion.Controls.Add(this.label6);
            this.panelCreateQuestion.Controls.Add(this.richTextBoxAnswerC);
            this.panelCreateQuestion.Controls.Add(this.label5);
            this.panelCreateQuestion.Controls.Add(this.richTextBoxAnswerB);
            this.panelCreateQuestion.Controls.Add(this.label4);
            this.panelCreateQuestion.Controls.Add(this.richTextBoxAnswerA);
            this.panelCreateQuestion.Controls.Add(this.label3);
            this.panelCreateQuestion.Controls.Add(this.richTextBoxQuestion);
            this.panelCreateQuestion.Controls.Add(this.label2);
            this.panelCreateQuestion.Controls.Add(this.label1);
            this.panelCreateQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreateQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelCreateQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.panelCreateQuestion.Name = "panelCreateQuestion";
            this.panelCreateQuestion.Size = new System.Drawing.Size(810, 541);
            this.panelCreateQuestion.TabIndex = 47;
            this.panelCreateQuestion.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(515, 352);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Current Question Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(637, 349);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(132, 20);
            this.textBoxId.TabIndex = 44;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(518, 287);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 32);
            this.buttonReset.TabIndex = 43;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(518, 225);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 32);
            this.buttonUpdate.TabIndex = 42;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDetele
            // 
            this.buttonDetele.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDetele.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonDetele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetele.ForeColor = System.Drawing.Color.White;
            this.buttonDetele.Location = new System.Drawing.Point(518, 167);
            this.buttonDetele.Name = "buttonDetele";
            this.buttonDetele.Size = new System.Drawing.Size(117, 32);
            this.buttonDetele.TabIndex = 41;
            this.buttonDetele.Text = "Delete";
            this.buttonDetele.UseVisualStyleBackColor = false;
            this.buttonDetele.Click += new System.EventHandler(this.buttonDetele_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(518, 104);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 32);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Question Table";
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(31, 377);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.Size = new System.Drawing.Size(738, 150);
            this.dataGridViewQuestions.TabIndex = 38;
            this.dataGridViewQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuestions_CellClick);
            // 
            // comboBoxRightAnswer
            // 
            this.comboBoxRightAnswer.FormattingEnabled = true;
            this.comboBoxRightAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxRightAnswer.Location = new System.Drawing.Point(518, 36);
            this.comboBoxRightAnswer.Name = "comboBoxRightAnswer";
            this.comboBoxRightAnswer.Size = new System.Drawing.Size(117, 21);
            this.comboBoxRightAnswer.TabIndex = 37;
            this.comboBoxRightAnswer.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Right Answer";
            // 
            // richTextBoxAnswerD
            // 
            this.richTextBoxAnswerD.Location = new System.Drawing.Point(85, 284);
            this.richTextBoxAnswerD.Name = "richTextBoxAnswerD";
            this.richTextBoxAnswerD.Size = new System.Drawing.Size(329, 42);
            this.richTextBoxAnswerD.TabIndex = 35;
            this.richTextBoxAnswerD.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Answer D";
            // 
            // richTextBoxAnswerC
            // 
            this.richTextBoxAnswerC.Location = new System.Drawing.Point(85, 222);
            this.richTextBoxAnswerC.Name = "richTextBoxAnswerC";
            this.richTextBoxAnswerC.Size = new System.Drawing.Size(329, 42);
            this.richTextBoxAnswerC.TabIndex = 33;
            this.richTextBoxAnswerC.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Answer C";
            // 
            // richTextBoxAnswerB
            // 
            this.richTextBoxAnswerB.Location = new System.Drawing.Point(85, 164);
            this.richTextBoxAnswerB.Name = "richTextBoxAnswerB";
            this.richTextBoxAnswerB.Size = new System.Drawing.Size(329, 42);
            this.richTextBoxAnswerB.TabIndex = 31;
            this.richTextBoxAnswerB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Answer B";
            // 
            // richTextBoxAnswerA
            // 
            this.richTextBoxAnswerA.Location = new System.Drawing.Point(85, 101);
            this.richTextBoxAnswerA.Name = "richTextBoxAnswerA";
            this.richTextBoxAnswerA.Size = new System.Drawing.Size(329, 42);
            this.richTextBoxAnswerA.TabIndex = 29;
            this.richTextBoxAnswerA.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Answer A";
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Location = new System.Drawing.Point(85, 36);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(329, 42);
            this.richTextBoxQuestion.TabIndex = 27;
            this.richTextBoxQuestion.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Create Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Question";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
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
            this.panel2.TabIndex = 46;
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
            // frmTeacherEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 683);
            this.Controls.Add(this.panelCreateQuestion);
            this.Controls.Add(this.panel2);
            this.Name = "frmTeacherEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.frmTeacherEdit_Load);
            this.panelCreateQuestion.ResumeLayout(false);
            this.panelCreateQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateQuestion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDetele;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.ComboBox comboBoxRightAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLoadTestSet;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxTestCode;
        private System.Windows.Forms.Label labelCreateTest;
        private System.Windows.Forms.Label label;

        public Panel PanelCreateQuestion { get => panelCreateQuestion; set => panelCreateQuestion = value; }
        public TextBox TextBoxId { get => textBoxId; set => textBoxId = value; }
        public DataGridView DataGridViewQuestions { get => dataGridViewQuestions; set => dataGridViewQuestions = value; }
        public ComboBox ComboBoxRightAnswer { get => comboBoxRightAnswer; set => comboBoxRightAnswer = value; }
        public RichTextBox RichTextBoxAnswerD { get => richTextBoxAnswerD; set => richTextBoxAnswerD = value; }
        public RichTextBox RichTextBoxAnswerC { get => richTextBoxAnswerC; set => richTextBoxAnswerC = value; }
        public RichTextBox RichTextBoxAnswerB { get => richTextBoxAnswerB; set => richTextBoxAnswerB = value; }
        public RichTextBox RichTextBoxAnswerA { get => richTextBoxAnswerA; set => richTextBoxAnswerA = value; }
        public RichTextBox RichTextBoxQuestion { get => richTextBoxQuestion; set => richTextBoxQuestion = value; }
        public TextBox TextBoxTestCode { get => textBoxTestCode; set => textBoxTestCode = value; }
        public Button ButtonLoadTestSet { get => buttonLoadTestSet; set => buttonLoadTestSet = value; }
    }
}