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
            Students = new List<Student>();
            students.ForEach(student => AddStudent(student));
        }

        public int ClassNumber { get; private set; }
        public List<Student> Students { get; }
        public Teacher Teacher { get; }

        public string Notify()
        {
            var welcomeMessage = string.Empty;
            welcomeMessage += Teacher.Say();
            Students.ForEach(student => welcomeMessage += student.Say());
            return welcomeMessage;
        }

        public string AddStudent(Student student)
        {
            student.Class = this;
            Students.Add(student);
            return Notify();
        }
    }
}