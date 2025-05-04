namespace MFT.PresentationLayer
{
    partial class FormTeacher
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
            labelFirstName = new Label();
            textBoxTeacherFirstName = new TextBox();
            buttonAdd = new Button();
            dataGridViewTeacher = new DataGridView();
            textBoxTeacherLastName = new TextBox();
            labelLastName = new Label();
            textBoxTeacherCode = new TextBox();
            labelTeacherCode = new Label();
            buttonGetAll = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonExit = new Button();
            textBoxTeacherId = new TextBox();
            labelTeacherId = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacher).BeginInit();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(140, 9);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(64, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name";
            // 
            // textBoxTeacherFirstName
            // 
            textBoxTeacherFirstName.Location = new Point(140, 27);
            textBoxTeacherFirstName.Name = "textBoxTeacherFirstName";
            textBoxTeacherFirstName.Size = new Size(100, 23);
            textBoxTeacherFirstName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Green;
            buttonAdd.ForeColor = Color.WhiteSmoke;
            buttonAdd.Location = new Point(190, 73);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 32);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewTeacher
            // 
            dataGridViewTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeacher.Location = new Point(7, 149);
            dataGridViewTeacher.Name = "dataGridViewTeacher";
            dataGridViewTeacher.Size = new Size(484, 150);
            dataGridViewTeacher.TabIndex = 3;
            dataGridViewTeacher.CellClick += dataGridViewTeacher_CellClick;
            // 
            // textBoxTeacherLastName
            // 
            textBoxTeacherLastName.Location = new Point(275, 27);
            textBoxTeacherLastName.Name = "textBoxTeacherLastName";
            textBoxTeacherLastName.Size = new Size(100, 23);
            textBoxTeacherLastName.TabIndex = 4;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(275, 9);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(63, 15);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Last Name";
            // 
            // textBoxTeacherCode
            // 
            textBoxTeacherCode.Location = new Point(391, 27);
            textBoxTeacherCode.Name = "textBoxTeacherCode";
            textBoxTeacherCode.Size = new Size(100, 23);
            textBoxTeacherCode.TabIndex = 13;
            // 
            // labelTeacherCode
            // 
            labelTeacherCode.AutoSize = true;
            labelTeacherCode.Location = new Point(391, 9);
            labelTeacherCode.Name = "labelTeacherCode";
            labelTeacherCode.Size = new Size(35, 15);
            labelTeacherCode.TabIndex = 7;
            labelTeacherCode.Text = "Code";
            // 
            // buttonGetAll
            // 
            buttonGetAll.BackColor = Color.LightBlue;
            buttonGetAll.ForeColor = Color.WhiteSmoke;
            buttonGetAll.Location = new Point(22, 73);
            buttonGetAll.Name = "buttonGetAll";
            buttonGetAll.Size = new Size(119, 32);
            buttonGetAll.TabIndex = 8;
            buttonGetAll.Text = "Get All";
            buttonGetAll.UseVisualStyleBackColor = false;
            buttonGetAll.Click += buttonGetAll_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.ForeColor = Color.WhiteSmoke;
            buttonDelete.Location = new Point(7, 111);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(232, 32);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Yellow;
            buttonUpdate.ForeColor = SystemColors.WindowFrame;
            buttonUpdate.Location = new Point(349, 73);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(119, 32);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.SaddleBrown;
            buttonExit.ForeColor = Color.WhiteSmoke;
            buttonExit.Location = new Point(259, 111);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(232, 32);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // textBoxTeacherId
            // 
            textBoxTeacherId.Location = new Point(7, 27);
            textBoxTeacherId.Name = "textBoxTeacherId";
            textBoxTeacherId.ReadOnly = true;
            textBoxTeacherId.Size = new Size(100, 23);
            textBoxTeacherId.TabIndex = 12;
            // 
            // labelTeacherId
            // 
            labelTeacherId.AutoSize = true;
            labelTeacherId.Location = new Point(7, 9);
            labelTeacherId.Name = "labelTeacherId";
            labelTeacherId.Size = new Size(17, 15);
            labelTeacherId.TabIndex = 14;
            labelTeacherId.Text = "Id";
            // 
            // FormTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 310);
            Controls.Add(labelTeacherId);
            Controls.Add(textBoxTeacherId);
            Controls.Add(buttonExit);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonGetAll);
            Controls.Add(labelTeacherCode);
            Controls.Add(textBoxTeacherCode);
            Controls.Add(labelLastName);
            Controls.Add(textBoxTeacherLastName);
            Controls.Add(dataGridViewTeacher);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTeacherFirstName);
            Controls.Add(labelFirstName);
            Name = "FormTeacher";
            Text = "FormTeacher";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private TextBox textBoxTeacherFirstName;
        private Button buttonAdd;
        private DataGridView dataGridViewTeacher;
        private TextBox textBoxTeacherLastName;
        private Label labelLastName;
        private TextBox textBoxTeacherCode;
        private Label labelTeacherCode;
        private Button buttonGetAll;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonExit;
        private TextBox textBoxTeacherId;
        private Label labelTeacherId;
    }
}