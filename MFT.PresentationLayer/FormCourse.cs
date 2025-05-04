using MFT.BusinessLogicLayer.Dtos.Courses;
using MFT.BusinessLogicLayer.Services;
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
    public partial class FormCourse : Form
    {
        private CourseService _courseService;
        public FormCourse()
        {
            InitializeComponent();
            _courseService = new CourseService();
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            var courseDto = _courseService.GetAll();
            dataGridViewCourse.DataSource = courseDto;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var row = dataGridViewCourse.Rows[index];

            textBoxCourseId.Text = row.Cells["Id"].Value.ToString();
            textBoxCourseName.Text = row.Cells["Name"].Value.ToString();
            textBoxCourseCapacity.Text = row.Cells["Capacity"].Value.ToString();
            textBoxCourseCode.Text = row.Cells["Code"].Value.ToString();
           



        }

        private void buttonCourseAdd_Click(object sender, EventArgs e)
        {
            AddCourseDto courseDto = new AddCourseDto();
            courseDto.Capacity = Convert.ToInt32(textBoxCourseCapacity.Text);
            courseDto.Name = textBoxCourseName.Text;
            courseDto.Code = textBoxCourseCode.Text;
            courseDto.TeacherId =Convert.ToInt32(textBoxTeacherCode.Text);
            _courseService.Add(courseDto);
            buttonGetAll_Click(sender, e);

        }

        private void buttonCourseUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCourseId.Text) ||
                string.IsNullOrWhiteSpace(textBoxCourseName.Text) ||
                string.IsNullOrWhiteSpace(textBoxCourseCapacity.Text) ||
                string.IsNullOrWhiteSpace(textBoxCourseCode.Text))
            {
                throw new Exception("first select a row and then insert all inputs");
                return;
            }
            UpdateCourseDto courseDto = new();
            courseDto.Id = Convert.ToInt32(textBoxCourseId.Text);
            courseDto.Name = textBoxCourseName.Text;
            courseDto.Capacity = Convert.ToInt32(textBoxCourseCapacity.Text);
            courseDto.Code = textBoxCourseCode.Text;

            _courseService.Update(courseDto);

            buttonGetAll_Click(sender, e);

        }

        private void buttonCourseDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxCourseId.Text))
            {
                throw new Exception("first select a row and then insert all inputs");
                return;
            }
            DeleteCourseDto courseDto = new DeleteCourseDto();
            courseDto.Id = Convert.ToInt32(textBoxCourseId.Text);

            _courseService.Delete(courseDto);

            buttonGetAll_Click(sender, e);
        }

       
    }
}
