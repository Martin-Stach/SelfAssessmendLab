using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmendLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var uProgram = new UProgram("Information Technology");

            var student1 = new Student("Karl");
            var student2 = new Student("Julia");
            var student3 = new Student("Oli");

            var course1 = new Course("Programming with C#");

            course1.AddStudent(student1);
            course1.AddStudent(student2);
            course1.AddStudent(student3);

            var teacher1 = new Teacher("Maria");

            course1.AddTeacher(teacher1);

            var degree1 = new Degree("Bachelor");

            degree1.AddCourse(course1.Name);

            uProgram.AddDegree(degree1);

            Console.WriteLine($"The program {uProgram.Name} is necessary for the degree {degree1.Name}.");
            Console.WriteLine($"The degree {degree1.Name} contains following course {degree1.GetCourse()}.");
            Console.WriteLine($"The course {course1.Name} has {course1.NumberOfAssignedStudents()} students assigned.");

            Console.ReadLine();
        }
    }
}
