using System.Collections.Generic;

namespace OOStepByStep
{
    public class Class
    {
        public Class(int classNumber)
        {
            ClassNumber = classNumber;
        }

        public Class(int classNumber, Teacher teacher, List<Student> students) : this(classNumber)
        {
            teacher.Class = this;
            Teacher = teacher;
            students.ForEach(student => student.Class = this);
            Students = students;
        }

        public int ClassNumber { get; private set; }
        public List<Student> Students { get; private set; }
        public Teacher Teacher { get; }
    }
}