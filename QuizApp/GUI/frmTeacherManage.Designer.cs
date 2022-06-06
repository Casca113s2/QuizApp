
using System.Windows.Forms;

namespace QuizApp.GUI
{
    partial class frmTeacherManage
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
            this.panelMainView = new System.Windows.Forms.Panel();
            this.textBoxTestSetCode = new System.Windows.Forms.TextBox();
            this.textBoxTestSetName = new System.Windows.Forms.TextBox();
            this.textBoxTestSetTime = new System.Windows.Forms.TextBox();
            this.textBoxTestSetCreator = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDetele = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTestSet = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.panelMainView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainView
            // 
            this.panelMainView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMainView.Controls.Add(this.dataGridViewQuestions);
            this.panelMainView.Controls.Add(this.label6);
            this.panelMainView.Controls.Add(this.textBoxTestSetCode);
            this.panelMainView.Controls.Add(this.textBoxTestSetName);
            this.panelMainView.Controls.Add(this.textBoxTestSetTime);
            this.panelMainView.Controls.Add(this.textBoxTestSetCreator);
            this.panelMainView.Controls.Add(this.buttonBack);
            this.panelMainView.Controls.Add(this.buttonReset);
            this.panelMainView.Controls.Add(this.buttonUpdate);
            this.panelMainView.Controls.Add(this.buttonDetele);
            this.panelMainView.Controls.Add(this.label8);
            this.panelMainView.Controls.Add(this.dataGridViewTestSet);
            this.panelMainView.Controls.Add(this.label5);
            this.panelMainView.Controls.Add(this.label4);
            this.panelMainView.Controls.Add(this.label3);
            this.panelMainView.Controls.Add(this.label2);
            this.panelMainView.Controls.Add(this.label1);
            this.panelMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainView.Location = new System.Drawing.Point(0, 0);
            this.panelMainView.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainView.Name = "panelMainView";
            this.panelMainView.Size = new System.Drawing.Size(810, 683);
            this.panelMainView.TabIndex = 49;
            // 
            // textBoxTestSetCode
            // 
            this.textBoxTestSetCode.Location = new System.Drawing.Point(117, 47);
            this.textBoxTestSetCode.Name = "textBoxTestSetCode";
            this.textBoxTestSetCode.Size = new System.Drawing.Size(228, 20);
            this.textBoxTestSetCode.TabIndex = 47;
            // 
            // textBoxTestSetName
            // 
            this.textBoxTestSetName.Location = new System.Drawing.Point(117, 88);
            this.textBoxTestSetName.Name = "textBoxTestSetName";
            this.textBoxTestSetName.Size = new System.Drawing.Size(228, 20);
            this.textBoxTestSetName.TabIndex = 46;
            // 
            // textBoxTestSetTime
            // 
            this.textBoxTestSetTime.Location = new System.Drawing.Point(117, 132);
            this.textBoxTestSetTime.Name = "textBoxTestSetTime";
            this.textBoxTestSetTime.Size = new System.Drawing.Size(228, 20);
            this.textBoxTestSetTime.TabIndex = 45;
            // 
            // textBoxTestSetCreator
            // 
            this.textBoxTestSetCreator.Location = new System.Drawing.Point(117, 175);
            this.textBoxTestSetCreator.Name = "textBoxTestSetCreator";
            this.textBoxTestSetCreator.ReadOnly = true;
            this.textBoxTestSetCreator.Size = new System.Drawing.Size(228, 20);
            this.textBoxTestSetCreator.TabIndex = 44;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(652, 639);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 32);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(652, 218);
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
            this.buttonUpdate.Location = new System.Drawing.Point(515, 218);
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
            this.buttonDetele.Location = new System.Drawing.Point(373, 218);
            this.buttonDetele.Name = "buttonDetele";
            this.buttonDetele.Size = new System.Drawing.Size(117, 32);
            this.buttonDetele.TabIndex = 41;
            this.buttonDetele.Text = "Delete";
            this.buttonDetele.UseVisualStyleBackColor = false;
            this.buttonDetele.Click += new System.EventHandler(this.buttonDetele_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Test Set Table";
            // 
            // dataGridViewTestSet
            // 
            this.dataGridViewTestSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestSet.Location = new System.Drawing.Point(31, 256);
            this.dataGridViewTestSet.Name = "dataGridViewTestSet";
            this.dataGridViewTestSet.Size = new System.Drawing.Size(738, 147);
            this.dataGridViewTestSet.TabIndex = 38;
            this.dataGridViewTestSet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTestSet_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Test Set Creator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Test Set Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Test Set Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Test Set Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Test Set Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 424);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Question Table";
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(31, 440);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.Size = new System.Drawing.Size(738, 179);
            this.dataGridViewQuestions.TabIndex = 49;
            // 
            // frmTeacherManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(810, 683);
            this.Controls.Add(this.panelMainView);
            this.Name = "frmTeacherManage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.frmTeacherManage_Load);
            this.panelMainView.ResumeLayout(false);
            this.panelMainView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainView;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDetele;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewTestSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxTestSetCreator;
        private System.Windows.Forms.TextBox textBoxTestSetCode;
        private System.Windows.Forms.TextBox textBoxTestSetName;
        private System.Windows.Forms.TextBox textBoxTestSetTime;
        private DataGridView dataGridViewQuestions;
        private Label label6;

        public TextBox TextBoxTestSetCreator { get => textBoxTestSetCreator; set => textBoxTestSetCreator = value; }
        public TextBox TextBoxTestSetCode { get => textBoxTestSetCode; set => textBoxTestSetCode = value; }
        public TextBox TextBoxTestSetName { get => textBoxTestSetName; set => textBoxTestSetName = value; }
        public TextBox TextBoxTestSetTime { get => textBoxTestSetTime; set => textBoxTestSetTime = value; }
        public DataGridView DataGridViewTestSet { get => dataGridViewTestSet; set => dataGridViewTestSet = value; }
        public DataGridView DataGridViewQuestions { get => dataGridViewQuestions; set => dataGridViewQuestions = value; }
    }
}