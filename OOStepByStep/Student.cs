using System;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public Class Class { get; set; }

        public override string Introduce()
        {
            if (Class != null)
            {
                return base.Introduce() + $" I am a student of class {Class.ClassNumber}.";
            }

            return base.Introduce() + " I am a student.";
        }
    }
}