using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Person
    {
        private readonly string name;
        private readonly int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        protected string Name => name;
        protected int Age => age;

        public virtual string Introduce()
        {
            return "My name is " + name + ". I am " + age + " years old";
        }
    }
}
