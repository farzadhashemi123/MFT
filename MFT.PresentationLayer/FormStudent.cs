using MFT.BusinessLogicLayer.Dtos.Students;
using MFT.BusinessLogicLayer.Services;
using System.Diagnostics;

namespace MFT.PresentationLayer
{
    public partial class FormStudent : Form
    {
        private StudentService _studentService;
        public FormStudent()
        {
            InitializeComponent();

            _studentService = new StudentService();
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            var studentsDto = _studentService.GetAll();

            ClearAllTextBoxes();
            dataGridViewStudent.DataSource = studentsDto;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            var index = e.RowIndex;
            var row = dataGridViewStudent.Rows[index];

            textBoxStudentId.Text = row.Cells["Id"].Value.ToString();
            textBoxStudentFirstName.Text = row.Cells["FirstName"].Value.ToString();
            textBoxStudentLastName.Text = row.Cells["LastName"].Value.ToString();
            textBoxStudentNationalId.Text = row.Cells["NationalId"].Value.ToString();
            textBoxStudentCode.Text = row.Cells["Code"].Value.ToString();
        }

        private void buttonStudentAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxStudentFirstName.Text) ||
               string.IsNullOrWhiteSpace(textBoxStudentLastName.Text) ||
               string.IsNullOrWhiteSpace(textBoxStudentNationalId.Text))
            {
                MessageBox.Show("Please enter firstName, lastName and National id.");
                return;
            }

            AddStudentDto studentDto = new AddStudentDto();
            studentDto.FirstName = textBoxStudentFirstName.Text;
            studentDto.LastName = textBoxStudentLastName.Text;
            studentDto.NationalId = textBoxStudentNationalId.Text;

            _studentService.Add(studentDto);

            ClearAllTextBoxes();
            buttonGetAll_Click(sender, e); // refresh dataGridView
        }

        private void buttonStudentUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxStudentId.Text) ||
                string.IsNullOrWhiteSpace(textBoxStudentFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxStudentLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxStudentNationalId.Text))
            {
                MessageBox.Show("Please first select a row and then enter firstName, lastName and National id.");
                return;
            }

            UpdateStudentDto studentDto = new UpdateStudentDto();
            studentDto.Id = int.Parse(textBoxStudentId.Text);
            studentDto.FirstName = textBoxStudentFirstName.Text;
            studentDto.LastName = textBoxStudentLastName.Text;
            studentDto.NationalId = textBoxStudentNationalId.Text;

            _studentService.Update(studentDto);

            ClearAllTextBoxes();
            buttonGetAll_Click(sender, e); // refresh dataGridView
        }

        private void buttonStudentDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxStudentId.Text))
            {
                MessageBox.Show("Please first select a row.");
                return;
            }

            DeleteStudentDto studentDto = new DeleteStudentDto();
            studentDto.Id = int.Parse(textBoxStudentId.Text);

            _studentService.Delete(studentDto);

            ClearAllTextBoxes();
            buttonGetAll_Click(sender, e); // refresh dataGridView
        }

        private void ClearAllTextBoxes()
        {
            textBoxStudentId.Clear();
            textBoxStudentFirstName.Clear();
            textBoxStudentLastName.Clear();
            textBoxStudentNationalId.Clear();
            textBoxStudentCode.Clear();
        }
    }
}
