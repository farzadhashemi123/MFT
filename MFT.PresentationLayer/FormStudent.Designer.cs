namespace MFT.PresentationLayer
{
    partial class FormStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxStudentId = new TextBox();
            labelStudentId = new Label();
            buttonStudentAdd = new Button();
            labelStudentFirstName = new Label();
            textBoxStudentFirstName = new TextBox();
            labelStudentLastName = new Label();
            textBoxStudentLastName = new TextBox();
            labelStudentNationalId = new Label();
            textBoxStudentNationalId = new TextBox();
            labelStudentCode = new Label();
            textBoxStudentCode = new TextBox();
            buttonStudentUpdate = new Button();
            buttonGetAll = new Button();
            buttonStudentDelete = new Button();
            buttonExit = new Button();
            dataGridViewStudent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            SuspendLayout();
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Enabled = false;
            textBoxStudentId.Location = new Point(23, 41);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.ReadOnly = true;
            textBoxStudentId.Size = new Size(125, 27);
            textBoxStudentId.TabIndex = 0;
            // 
            // labelStudentId
            // 
            labelStudentId.AutoSize = true;
            labelStudentId.Location = new Point(23, 9);
            labelStudentId.Name = "labelStudentId";
            labelStudentId.Size = new Size(22, 20);
            labelStudentId.TabIndex = 1;
            labelStudentId.Text = "Id";
            // 
            // buttonStudentAdd
            // 
            buttonStudentAdd.BackColor = Color.Green;
            buttonStudentAdd.ForeColor = SystemColors.ButtonFace;
            buttonStudentAdd.Location = new Point(163, 90);
            buttonStudentAdd.Name = "buttonStudentAdd";
            buttonStudentAdd.Size = new Size(125, 29);
            buttonStudentAdd.TabIndex = 2;
            buttonStudentAdd.Text = "Add";
            buttonStudentAdd.UseVisualStyleBackColor = false;
            buttonStudentAdd.Click += buttonStudentAdd_Click;
            // 
            // labelStudentFirstName
            // 
            labelStudentFirstName.AutoSize = true;
            labelStudentFirstName.Location = new Point(163, 9);
            labelStudentFirstName.Name = "labelStudentFirstName";
            labelStudentFirstName.Size = new Size(73, 20);
            labelStudentFirstName.TabIndex = 4;
            labelStudentFirstName.Text = "Firstname";
            // 
            // textBoxStudentFirstName
            // 
            textBoxStudentFirstName.Location = new Point(163, 41);
            textBoxStudentFirstName.Name = "textBoxStudentFirstName";
            textBoxStudentFirstName.Size = new Size(125, 27);
            textBoxStudentFirstName.TabIndex = 3;
            // 
            // labelStudentLastName
            // 
            labelStudentLastName.AutoSize = true;
            labelStudentLastName.Location = new Point(306, 9);
            labelStudentLastName.Name = "labelStudentLastName";
            labelStudentLastName.Size = new Size(72, 20);
            labelStudentLastName.TabIndex = 6;
            labelStudentLastName.Text = "Lastname";
            // 
            // textBoxStudentLastName
            // 
            textBoxStudentLastName.Location = new Point(306, 41);
            textBoxStudentLastName.Name = "textBoxStudentLastName";
            textBoxStudentLastName.Size = new Size(125, 27);
            textBoxStudentLastName.TabIndex = 5;
            // 
            // labelStudentNationalId
            // 
            labelStudentNationalId.AutoSize = true;
            labelStudentNationalId.Location = new Point(446, 9);
            labelStudentNationalId.Name = "labelStudentNationalId";
            labelStudentNationalId.Size = new Size(83, 20);
            labelStudentNationalId.TabIndex = 8;
            labelStudentNationalId.Text = "National id";
            // 
            // textBoxStudentNationalId
            // 
            textBoxStudentNationalId.Location = new Point(446, 41);
            textBoxStudentNationalId.Name = "textBoxStudentNationalId";
            textBoxStudentNationalId.Size = new Size(125, 27);
            textBoxStudentNationalId.TabIndex = 7;
            // 
            // labelStudentCode
            // 
            labelStudentCode.AutoSize = true;
            labelStudentCode.Location = new Point(588, 9);
            labelStudentCode.Name = "labelStudentCode";
            labelStudentCode.Size = new Size(99, 20);
            labelStudentCode.TabIndex = 10;
            labelStudentCode.Text = "Student Code";
            // 
            // textBoxStudentCode
            // 
            textBoxStudentCode.Location = new Point(588, 41);
            textBoxStudentCode.Name = "textBoxStudentCode";
            textBoxStudentCode.ReadOnly = true;
            textBoxStudentCode.Size = new Size(125, 27);
            textBoxStudentCode.TabIndex = 9;
            // 
            // buttonStudentUpdate
            // 
            buttonStudentUpdate.BackColor = Color.Orange;
            buttonStudentUpdate.ForeColor = SystemColors.ButtonFace;
            buttonStudentUpdate.Location = new Point(306, 90);
            buttonStudentUpdate.Name = "buttonStudentUpdate";
            buttonStudentUpdate.Size = new Size(125, 29);
            buttonStudentUpdate.TabIndex = 11;
            buttonStudentUpdate.Text = "Update";
            buttonStudentUpdate.UseVisualStyleBackColor = false;
            buttonStudentUpdate.Click += buttonStudentUpdate_Click;
            // 
            // buttonGetAll
            // 
            buttonGetAll.BackColor = SystemColors.ActiveCaption;
            buttonGetAll.ForeColor = SystemColors.ButtonFace;
            buttonGetAll.Location = new Point(23, 90);
            buttonGetAll.Name = "buttonGetAll";
            buttonGetAll.Size = new Size(125, 29);
            buttonGetAll.TabIndex = 12;
            buttonGetAll.Text = "Get All";
            buttonGetAll.UseVisualStyleBackColor = false;
            buttonGetAll.Click += buttonGetAll_Click;
            // 
            // buttonStudentDelete
            // 
            buttonStudentDelete.BackColor = Color.Crimson;
            buttonStudentDelete.ForeColor = SystemColors.ButtonFace;
            buttonStudentDelete.Location = new Point(446, 90);
            buttonStudentDelete.Name = "buttonStudentDelete";
            buttonStudentDelete.Size = new Size(125, 29);
            buttonStudentDelete.TabIndex = 13;
            buttonStudentDelete.Text = "Delete";
            buttonStudentDelete.UseVisualStyleBackColor = false;
            buttonStudentDelete.Click += buttonStudentDelete_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Sienna;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.ForeColor = SystemColors.ButtonFace;
            buttonExit.Location = new Point(588, 90);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(125, 29);
            buttonExit.TabIndex = 14;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Location = new Point(23, 136);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.Size = new Size(690, 302);
            dataGridViewStudent.TabIndex = 15;
            dataGridViewStudent.CellClick += dataGridViewStudent_CellClick;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 450);
            Controls.Add(dataGridViewStudent);
            Controls.Add(buttonExit);
            Controls.Add(buttonStudentDelete);
            Controls.Add(buttonGetAll);
            Controls.Add(buttonStudentUpdate);
            Controls.Add(labelStudentCode);
            Controls.Add(textBoxStudentCode);
            Controls.Add(labelStudentNationalId);
            Controls.Add(textBoxStudentNationalId);
            Controls.Add(labelStudentLastName);
            Controls.Add(textBoxStudentLastName);
            Controls.Add(labelStudentFirstName);
            Controls.Add(textBoxStudentFirstName);
            Controls.Add(buttonStudentAdd);
            Controls.Add(labelStudentId);
            Controls.Add(textBoxStudentId);
            Name = "FormStudent";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStudentId;
        private Label labelStudentId;
        private Button buttonStudentAdd;
        private Label labelStudentFirstName;
        private TextBox textBoxStudentFirstName;
        private Label labelStudentLastName;
        private TextBox textBoxStudentLastName;
        private Label labelStudentNationalId;
        private TextBox textBoxStudentNationalId;
        private Label labelStudentCode;
        private TextBox textBoxStudentCode;
        private Button buttonStudentUpdate;
        private Button buttonGetAll;
        private Button buttonStudentDelete;
        private Button buttonExit;
        private DataGridView dataGridViewStudent;
    }
}
