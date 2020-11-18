using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Person
    {
        private int classNumber;
        private string name;
        private int age;
        public Person(string name, int age, int classNumber)
        {
            this.name = name;
            this.age = age;
            this.classNumber = classNumber;
        }

        public int GetClassNumber()
        {
            return classNumber;
        }

        public virtual string Introduce()
        {
            return "My name is " + name + ". I am " + age + " years old";
        }
    }
}
