using System;

namespace OOStepByStep
{
    public class Teacher : Person, IObserver
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        //property Class should not be included in the Person class right?
        public Class Class
        {
            get; set;
        }

        public override string Introduce()
        {
            if (Class != null)
            {
                return base.Introduce() + $" I am a teacher of class {Class.ClassNumber}.";
            }

            return base.Introduce() + " I am a teacher.";
        }

        public string Say()
        {
            return Introduce() + $" Welcome Tom join class {Class.ClassNumber}.";
        }
    }
}