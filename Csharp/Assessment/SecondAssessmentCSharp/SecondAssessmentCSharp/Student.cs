using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssessmentCSharp
{
    abstract class Student
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public float Grade { get; set; }


        public abstract bool IsPassed(float grade);
    }
}