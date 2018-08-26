using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmendLab
{
    class Student
    {
        private string _name { get; set; }
        private static int _numberOfStudents;

        public Student(string name)
        {
            _name = name;

            _numberOfStudents++;
        }

        public static int CountStudents()
        {
            return _numberOfStudents;
        }

    }
}
