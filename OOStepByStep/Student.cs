using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Student
    {
        private string name;
        private int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Introduce()
        {
            return "My name is " + name + ". I am " + age + " years old";
        }
    }
}
