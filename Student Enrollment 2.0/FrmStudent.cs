﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Enrollment_2
{
    public partial class FrmStudent : Form
    {
        private ClsStudent _Student;
        public FrmStudent()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(ClsStudent prStudent)
        {
            _Student = prStudent;
            updateDisplay();
            return ShowDialog();
        }

        private void updateDisplay()
        {
            txtID.Text = _Student.ID;
            txtName.Text = _Student.Name;
            dtpDOB.Value = _Student.DOB;
            txtBalance.Text = Convert.ToString(_Student.Balance);
            txtID.Enabled = String.IsNullOrEmpty(_Student.ID);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _Student.ID = txtID.Text;
            _Student.Name = txtName.Text;
            _Student.DOB = dtpDOB.Value;
            _Student.Balance = Convert.ToDecimal(txtBalance.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
