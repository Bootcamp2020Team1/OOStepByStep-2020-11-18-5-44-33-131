using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age, int classNumber) : base(name, age, classNumber)
        {
        }

        public override string Introduce()
        {
            return base.Introduce() + ". I am a teacher of class " + GetClassNumber().ToString();
        }
    }
}
