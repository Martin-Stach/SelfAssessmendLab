using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmendLab
{
    class UProgram : BaseClass
    {
        private string _schoolProgram;

        private List<Degree> _degrees = new List<Degree>();

        public UProgram(string ProgramName)
        {
            this.Name = ProgramName;
            //this._schoolProgram = Program;
        }

        public void AddDegree(Degree degree)
        {
            _degrees.Add(degree);
        }
    }
}