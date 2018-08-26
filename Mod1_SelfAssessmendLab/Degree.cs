using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmendLab
{
    class Degree : BaseClass
    {
        // private IList<Course> _courses;
        private string _course;

        public Degree(string Name)
        {
            this.Name = Name;
        }

        public void AddCourse(string course)
        {
            _course = course;
        }

        public string GetCourse()
        {
            return _course;
        }
    }
}
