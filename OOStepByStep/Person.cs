namespace OOStepByStep
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public virtual string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }
}