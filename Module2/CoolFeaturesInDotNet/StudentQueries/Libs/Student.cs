﻿namespace StudentQueries.Libs
{
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<double> Marks { get; set; }

        public string GroupNumber { get; set; }
    }
}
