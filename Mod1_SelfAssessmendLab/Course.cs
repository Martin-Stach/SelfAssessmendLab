using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmendLab
{
    class Course : BaseClass
    {
        private string _courseName;
        // private Student[] _students = new Student[10];
        private List<Student> _students = new List<Student>();
        private List<Teacher> _teacher = new List<Teacher>();

        public Course(string CourseName)
        {
            this.Name = CourseName;
        }
        
        public void AddStudent(Student student)
        {
            //_students[student];
            _students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            _teacher.Add(teacher);
        }

        public int NumberOfAssignedStudents()
        {
            return _students.Count();
        }
    }
}
