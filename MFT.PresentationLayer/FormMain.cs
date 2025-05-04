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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFormStudent_Click(object sender, EventArgs e)
        {
            var formStudent = new FormStudent();
            formStudent.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFormCourse_Click(object sender, EventArgs e)
        {
            var formCourse = new FormCourse();
            formCourse.Show();
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            var formTeacher = new FormTeacher();
            formTeacher.Show();
        }
    }
}
