using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssessmentCSharp
{
    class UnderGraduate : Student 
    {
        public override bool IsPassed(float grade)
        {
            if (grade >= 70.0f) return true;
            else return false;
        }
    }
}
