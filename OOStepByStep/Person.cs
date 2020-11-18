namespace OOStepByStepTest
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }
}