namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, Class studentClass) : base(name, age)
        {
            Class = studentClass;
        }

        public Class Class { get; set; }

        public override string Introduce()
        {
            if (Class != null)
            {
                return base.Introduce() + $" I am a student of {Class.ClassName}.";
            }

            return base.Introduce() + " I am a student.";
        }
    }
}