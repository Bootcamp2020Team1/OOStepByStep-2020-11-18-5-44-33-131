namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, Class teacherClass) : base(name, age)
        {
            Class = teacherClass;
        }

        //property Class should not be included in the Person class right?
        public Class Class { get; set; }

        public override string Introduce()
        {
            if (Class != null)
            {
                return base.Introduce() + $" I am a teacher of {Class.ClassName}.";
            }

            return base.Introduce() + " I am a teacher.";
        }
    }
}