using MFT.BusinessLogicLayer.Dtos.TeacherDto;
using MFT.BusinessLogicLayer.Services;
using MFT.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFT.PresentationLayer
{
    public partial class FormTeacher : Form
    {
        private TeacherService _teacherService;
        public FormTeacher()
        {
            InitializeComponent();
            _teacherService = new TeacherService();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dataGridViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            var index = e.RowIndex;
            var row = dataGridViewTeacher.Rows[index];

            textBoxTeacherId.Text = row.Cells["Id"].Value.ToString();
            textBoxTeacherFirstName.Text = row.Cells["FirstName"].Value.ToString();
            textBoxTeacherLastName.Text = row.Cells["LastName"].Value.ToString();
            textBoxTeacherCode.Text = row.Cells["TeacherCode"].Value.ToString();


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTeacherLastName.Text) ||
                string.IsNullOrEmpty(textBoxTeacherFirstName.Text) ||
                 string.IsNullOrEmpty(textBoxTeacherCode.Text))
            {
                MessageBox.Show("please enter all inputs");
                return;
            }
            AddTeachertDto teacherDto = new AddTeachertDto();
            teacherDto.FirstName = textBoxTeacherFirstName.Text;
            teacherDto.LastName = textBoxTeacherLastName.Text;
            teacherDto.Code = textBoxTeacherCode.Text;

            _teacherService.Add(teacherDto);

            ClearAllTextBoxes();
            buttonGetAll_Click(sender, e);

        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            var teachetDto = _teacherService.GetAll();

            dataGridViewTeacher.DataSource = teachetDto;
        }
        private void ClearAllTextBoxes()
        {
            textBoxTeacherFirstName.Clear();
            textBoxTeacherLastName.Clear();
            textBoxTeacherCode.Clear();
            textBoxTeacherId.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteTeacherDto teacherDto = new();
            teacherDto.Id = Convert.ToInt32(textBoxTeacherId.Text);

            _teacherService.Delete(teacherDto);

            ClearAllTextBoxes();
            buttonGetAll_Click(sender, e);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTeacherFirstName.Text)||
                string.IsNullOrWhiteSpace(textBoxTeacherLastName.Text)||
                 string.IsNullOrWhiteSpace(textBoxTeacherCode.Text))
            {
                throw new Exception("please insert all inputs");
                return; 
            }
            UpdateTeacherDto teacherDto = new UpdateTeacherDto();
            teacherDto.FirstName = textBoxTeacherFirstName.Text;
            teacherDto.LastName = textBoxTeacherLastName.Text;
            teacherDto.Id = Convert.ToInt32(textBoxTeacherId.Text);
            teacherDto.Code = textBoxTeacherCode.Text;

            _teacherService.Update(teacherDto);

            ClearAllTextBoxes();
            buttonGetAll_Click(sender, e);
        }

        }
    }
