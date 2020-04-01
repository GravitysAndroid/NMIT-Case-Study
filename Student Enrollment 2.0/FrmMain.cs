using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Enrollment_2._0
{
    public partial class FrmMain : Form
    {
        private ClsStudent _Student;
        private FrmStudent _StudentForm = new FrmStudent();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            _Student = new ClsStudent();
            editStudent();
        }

        private void editStudent()
        {
            if (_Student != null &&
            _StudentForm.ShowDialog(_Student) == DialogResult.OK)
            {
                lblStudent.Text = "Student:\n" + _Student.ToString();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            _Student = new ClsStudent();
            editStudent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
