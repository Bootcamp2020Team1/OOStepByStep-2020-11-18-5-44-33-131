using System;

namespace OOStepByStep
{
    public class Student : Person, IObserver
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

        public string Say()
        {
            return Introduce() + $" Welcome Jim join class {Class.ClassNumber}.";
        }
    }
}