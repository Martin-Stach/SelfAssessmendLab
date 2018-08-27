using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcsCourse_edX_ClassDemo
{
    abstract class Person
    {
        private string _firstName;
        private string _lastName;
        private int _birthYear;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int BirthYear { get => _birthYear; set => _birthYear = value; }


    }
}
