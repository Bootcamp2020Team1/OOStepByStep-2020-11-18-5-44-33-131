namespace OOStepByStep
{
    using System;
    public class Teacher : Person
    {
        private readonly int classNumber;
        public Teacher(string name, int age, IClass myClass) : base(name, age)
        {
            classNumber = myClass.GetClassNumber();
        }

        public override string Introduce()
        {
            return base.Introduce() + $" I am a teacher of class {classNumber}.";
        }

        public string Welcome(Student newStudent)
        {
            return Introduce() + $" Welcome {newStudent.Name} join class {classNumber}.";
        }
    }
}
