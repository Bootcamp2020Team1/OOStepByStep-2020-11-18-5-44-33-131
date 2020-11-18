using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age, int classNumber) : base(name, age, classNumber)
        {
        }

        public override string Introduce()
        {
            return base.Introduce() + ". I am a student of class " + GetClassNumber().ToString();
        }
    }
}
