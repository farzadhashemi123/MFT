namespace MFT.PresentationLayer
{
    partial class FormMain
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
            buttonFormStudent = new Button();
            buttonFormCourse = new Button();
            buttonFormCourseStudent = new Button();
            buttonExit = new Button();
            buttonTeacher = new Button();
            SuspendLayout();
            // 
            // buttonFormStudent
            // 
            buttonFormStudent.Location = new Point(12, 9);
            buttonFormStudent.Margin = new Padding(3, 2, 3, 2);
            buttonFormStudent.Name = "buttonFormStudent";
            buttonFormStudent.Size = new Size(199, 40);
            buttonFormStudent.TabIndex = 0;
            buttonFormStudent.Text = "Show Students";
            buttonFormStudent.UseVisualStyleBackColor = true;
            buttonFormStudent.Click += buttonFormStudent_Click;
            // 
            // buttonFormCourse
            // 
            buttonFormCourse.Location = new Point(12, 53);
            buttonFormCourse.Margin = new Padding(3, 2, 3, 2);
            buttonFormCourse.Name = "buttonFormCourse";
            buttonFormCourse.Size = new Size(199, 40);
            buttonFormCourse.TabIndex = 1;
            buttonFormCourse.Text = "Show Courses";
            buttonFormCourse.UseVisualStyleBackColor = true;
            buttonFormCourse.Click += buttonFormCourse_Click;
            // 
            // buttonFormCourseStudent
            // 
            buttonFormCourseStudent.Location = new Point(10, 143);
            buttonFormCourseStudent.Margin = new Padding(3, 2, 3, 2);
            buttonFormCourseStudent.Name = "buttonFormCourseStudent";
            buttonFormCourseStudent.Size = new Size(199, 40);
            buttonFormCourseStudent.TabIndex = 2;
            buttonFormCourseStudent.Text = "Show Course/Student";
            buttonFormCourseStudent.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(10, 187);
            buttonExit.Margin = new Padding(3, 2, 3, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(199, 40);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonTeacher
            // 
            buttonTeacher.Location = new Point(12, 97);
            buttonTeacher.Margin = new Padding(3, 2, 3, 2);
            buttonTeacher.Name = "buttonTeacher";
            buttonTeacher.Size = new Size(199, 40);
            buttonTeacher.TabIndex = 4;
            buttonTeacher.Text = "Show Teacher";
            buttonTeacher.UseVisualStyleBackColor = true;
            buttonTeacher.Click += buttonTeacher_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(221, 238);
            Controls.Add(buttonTeacher);
            Controls.Add(buttonExit);
            Controls.Add(buttonFormCourseStudent);
            Controls.Add(buttonFormCourse);
            Controls.Add(buttonFormStudent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFormStudent;
        private Button buttonFormCourse;
        private Button buttonFormCourseStudent;
        private Button buttonExit;
        private Button buttonTeacher;
    }
}