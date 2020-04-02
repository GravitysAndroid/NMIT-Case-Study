using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Enrollment_2
{
    class ClsMOEStudent : ClsStudent

    {
        private decimal _LoanAmount;
        private bool _FullTime;

        public decimal LoanAmount { get => _LoanAmount; set => _LoanAmount = value; }
        public bool FullTime { get => _FullTime; set => _FullTime = value; }
    }
}