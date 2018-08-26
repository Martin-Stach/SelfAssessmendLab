using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmendLab
{
    class Teacher
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public Teacher(string name)
        {
            _name = name;
        }
    }
}
