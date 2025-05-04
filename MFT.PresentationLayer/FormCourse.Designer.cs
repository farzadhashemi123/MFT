namespace MFT.PresentationLayer
{
    partial class FormCourse
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
            textBoxCourseId = new TextBox();
            LabelCourseId = new Label();
            buttonCourseAdd = new Button();
            buttonCourseUpdate = new Button();
            buttonGetAll = new Button();
            buttonExit = new Button();
            buttonCourseDelete = new Button();
            textBoxCourseCapacity = new TextBox();
            textBoxCourseName = new TextBox();
            CourseName = new Label();
            labelCourseCapacity = new Label();
            labelCourseCode = new Label();
            textBoxCourseCode = new TextBox();
            dataGridViewCourse = new DataGridView();
            textBoxTeacherCode = new TextBox();
            labelTeacherCode = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourse).BeginInit();
            SuspendLayout();
            // 
            // textBoxCourseId
            // 
            textBoxCourseId.Enabled = false;
            textBoxCourseId.Location = new Point(12, 27);
            textBoxCourseId.Name = "textBoxCourseId";
            textBoxCourseId.ReadOnly = true;
            textBoxCourseId.Size = new Size(100, 23);
            textBoxCourseId.TabIndex = 0;
            // 
            // LabelCourseId
            // 
            LabelCourseId.AutoSize = true;
            LabelCourseId.Location = new Point(12, 9);
            LabelCourseId.Name = "LabelCourseId";
            LabelCourseId.Size = new Size(17, 15);
            LabelCourseId.TabIndex = 1;
            LabelCourseId.Text = "Id";
            // 
            // buttonCourseAdd
            // 
            buttonCourseAdd.BackColor = Color.Green;
            buttonCourseAdd.ForeColor = Color.White;
            buttonCourseAdd.Location = new Point(12, 67);
            buttonCourseAdd.Name = "buttonCourseAdd";
            buttonCourseAdd.Size = new Size(100, 23);
            buttonCourseAdd.TabIndex = 2;
            buttonCourseAdd.Text = "Add";
            buttonCourseAdd.UseVisualStyleBackColor = false;
            buttonCourseAdd.Click += buttonCourseAdd_Click;
            // 
            // buttonCourseUpdate
            // 
            buttonCourseUpdate.BackColor = Color.Orange;
            buttonCourseUpdate.ForeColor = Color.White;
            buttonCourseUpdate.Location = new Point(127, 67);
            buttonCourseUpdate.Name = "buttonCourseUpdate";
            buttonCourseUpdate.Size = new Size(100, 23);
            buttonCourseUpdate.TabIndex = 3;
            buttonCourseUpdate.Text = "Update";
            buttonCourseUpdate.UseVisualStyleBackColor = false;
            buttonCourseUpdate.Click += buttonCourseUpdate_Click;
            // 
            // buttonGetAll
            // 
            buttonGetAll.BackColor = Color.DarkCyan;
            buttonGetAll.DialogResult = DialogResult.Cancel;
            buttonGetAll.ForeColor = Color.WhiteSmoke;
            buttonGetAll.Location = new Point(362, 67);
            buttonGetAll.Name = "buttonGetAll";
            buttonGetAll.Size = new Size(100, 23);
            buttonGetAll.TabIndex = 4;
            buttonGetAll.Text = "Get All";
            buttonGetAll.UseVisualStyleBackColor = false;
            buttonGetAll.Click += buttonGetAll_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.DarkGoldenrod;
            buttonExit.ForeColor = Color.WhiteSmoke;
            buttonExit.Location = new Point(481, 67);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(100, 23);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonCourseDelete
            // 
            buttonCourseDelete.BackColor = Color.Red;
            buttonCourseDelete.ForeColor = Color.WhiteSmoke;
            buttonCourseDelete.Location = new Point(244, 67);
            buttonCourseDelete.Name = "buttonCourseDelete";
            buttonCourseDelete.Size = new Size(100, 23);
            buttonCourseDelete.TabIndex = 6;
            buttonCourseDelete.Text = "Delete";
            buttonCourseDelete.UseVisualStyleBackColor = false;
            buttonCourseDelete.Click += buttonCourseDelete_Click;
            // 
            // textBoxCourseCapacity
            // 
            textBoxCourseCapacity.Location = new Point(244, 27);
            textBoxCourseCapacity.Name = "textBoxCourseCapacity";
            textBoxCourseCapacity.Size = new Size(100, 23);
            textBoxCourseCapacity.TabIndex = 7;
            // 
            // textBoxCourseName
            // 
            textBoxCourseName.Location = new Point(127, 27);
            textBoxCourseName.Name = "textBoxCourseName";
            textBoxCourseName.Size = new Size(100, 23);
            textBoxCourseName.TabIndex = 8;
            // 
            // CourseName
            // 
            CourseName.AutoSize = true;
            CourseName.Location = new Point(127, 9);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(39, 15);
            CourseName.TabIndex = 9;
            CourseName.Text = "Name";
            // 
            // labelCourseCapacity
            // 
            labelCourseCapacity.AutoSize = true;
            labelCourseCapacity.Location = new Point(244, 9);
            labelCourseCapacity.Name = "labelCourseCapacity";
            labelCourseCapacity.Size = new Size(53, 15);
            labelCourseCapacity.TabIndex = 10;
            labelCourseCapacity.Text = "Capacity";
            // 
            // labelCourseCode
            // 
            labelCourseCode.AutoSize = true;
            labelCourseCode.Location = new Point(362, 9);
            labelCourseCode.Name = "labelCourseCode";
            labelCourseCode.Size = new Size(75, 15);
            labelCourseCode.TabIndex = 11;
            labelCourseCode.Text = "Course Code";
            // 
            // textBoxCourseCode
            // 
            textBoxCourseCode.Location = new Point(362, 27);
            textBoxCourseCode.Name = "textBoxCourseCode";
            textBoxCourseCode.Size = new Size(100, 23);
            textBoxCourseCode.TabIndex = 12;
            // 
            // dataGridViewCourse
            // 
            dataGridViewCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourse.Location = new Point(8, 96);
            dataGridViewCourse.Name = "dataGridViewCourse";
            dataGridViewCourse.Size = new Size(569, 204);
            dataGridViewCourse.TabIndex = 13;
            dataGridViewCourse.CellClick += dataGridViewCourse_CellClick;
            // 
            // textBoxTeacherCode
            // 
            textBoxTeacherCode.Location = new Point(481, 27);
            textBoxTeacherCode.Name = "textBoxTeacherCode";
            textBoxTeacherCode.Size = new Size(100, 23);
            textBoxTeacherCode.TabIndex = 14;
            // 
            // labelTeacherCode
            // 
            labelTeacherCode.AutoSize = true;
            labelTeacherCode.Location = new Point(481, 9);
            labelTeacherCode.Name = "labelTeacherCode";
            labelTeacherCode.Size = new Size(82, 15);
            labelTeacherCode.TabIndex = 15;
            labelTeacherCode.Text = "Teachert Code";
            // 
            // FormCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 305);
            Controls.Add(labelTeacherCode);
            Controls.Add(textBoxTeacherCode);
            Controls.Add(dataGridViewCourse);
            Controls.Add(textBoxCourseCode);
            Controls.Add(labelCourseCode);
            Controls.Add(labelCourseCapacity);
            Controls.Add(CourseName);
            Controls.Add(textBoxCourseName);
            Controls.Add(textBoxCourseCapacity);
            Controls.Add(buttonCourseDelete);
            Controls.Add(buttonExit);
            Controls.Add(buttonGetAll);
            Controls.Add(buttonCourseUpdate);
            Controls.Add(buttonCourseAdd);
            Controls.Add(LabelCourseId);
            Controls.Add(textBoxCourseId);
            Name = "FormCourse";
            Text = "FormCourse";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCourseId;
        private Label LabelCourseId;
        private Button buttonCourseAdd;
        private Button buttonCourseUpdate;
        private Button buttonGetAll;
        private Button buttonExit;
        private Button buttonCourseDelete;
        private TextBox textBoxCourseCapacity;
        private TextBox textBoxCourseName;
        private Label CourseName;
        private Label labelCourseCapacity;
        private Label labelCourseCode;
        private TextBox textBoxCourseCode;
        private DataGridView dataGridViewCourse;
        private TextBox textBoxTeacherCode;
        private Label labelTeacherCode;
    }
}