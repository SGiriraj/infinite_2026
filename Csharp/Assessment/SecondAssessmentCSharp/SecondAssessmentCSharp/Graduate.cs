using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssessmentCSharp
{
    internal class Graduate:Student
    {
        public override bool IsPassed(float grade)
        {
            if (grade >= 80.0f) return true;
            else return false;
        }
    }
}
