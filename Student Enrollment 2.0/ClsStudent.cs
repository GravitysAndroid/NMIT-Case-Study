﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Enrollment_2
{
    public class ClsStudent
    {
        private string _ID;
        private string _Name;
        private DateTime _DOB = DateTime.Today;
        private decimal _Balance;

        public override string ToString()
        {
            return _ID + "\n" + _Name;
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DateTime DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        public decimal Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
    }
}

