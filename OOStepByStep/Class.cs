using System.Collections.Generic;

namespace OOStepByStep
{
    public class Class
    {
        private List<IObserver> observers;
        public Class(int classNumber, Teacher teacher, List<Student> students)
        {
            ClassNumber = classNumber;
            teacher.Class = this;
            Students = new List<Student>();
            observers = new List<IObserver>();
            Teacher = teacher;
            observers.Add(Teacher);
            students.ForEach(student => AddStudent(student));
            students.ForEach(student => observers.Add(student));
        }

        public int ClassNumber { get; private set; }
        public List<Student> Students { get; }
        public Teacher Teacher { get; }

        public string Notify()
        {
            var welcomeMessage = string.Empty;
            observers.ForEach(observer => welcomeMessage += observer.Say());
            return welcomeMessage;
        }

        public string AddStudent(Student student)
        {
            student.Class = this;
            Students.Add(student);
            observers.Add(student);
            return Notify();
        }
    }
}
