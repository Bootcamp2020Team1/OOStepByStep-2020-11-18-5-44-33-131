using System.Collections.Generic;

namespace OOStepByStep
{
    public class Class
    {
        public Class(string className)
        {
            ClassName = className;
        }

        public string ClassName { get; private set; }
        public List<Student> Students { get; private set; }
        public Teacher Teacher { get; private set; }
    }
}