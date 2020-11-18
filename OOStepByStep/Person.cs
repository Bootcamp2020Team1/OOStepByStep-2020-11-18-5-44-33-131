namespace OOStepByStep
{
    using System;
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public virtual string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }
}
