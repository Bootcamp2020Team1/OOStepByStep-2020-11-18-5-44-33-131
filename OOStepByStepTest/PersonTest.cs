using OOStepByStep;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        //AC1
        [Fact]
        public void Should_A_Person_Return_String_Contains_Name_And_Age_When_Introduce()
        {
            //given
            string expected = "My name is Tom. I am 21 years old.";
            Person person = new Person("Tom", 21);

            //when
            string actual = person.Introduce();

            //then
            Assert.Equal(expected, actual);
        }

        //AC2
        [Fact]
        public void Should_A_Student_Return_String_Contains_Name_And_Age_And_Student_When_Introduce()
        {
            //given
            string expected = "My name is Tom. I am 18 years old. I am a student.";
            var person = new Student("Tom", 18);

            //when
            string actual = person.Introduce();

            //then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_A_Teacher_Return_String_Contains_Name_And_Age_And_Teacher_When_Introduce()
        {
            //given
            string expected = "My name is Amy. I am 30 years old. I am a teacher.";
            var person = new Teacher("Amy", 30);

            //when
            string actual = person.Introduce();

            //then
            Assert.Equal(expected, actual);
        }

        //AC3
        [Fact]
        public void Should_Return_String_Contains_Name_Age_Student_And_Class_When_A_Student__With_Class_Introduce()
        {
            //given
            string expected = "My name is Tom. I am 18 years old. I am a student of class 2.";
            var students = new List<Student>();
            students.Add(new Student("Tom", 18));
            var classTested = new Class(2, new Teacher("Amy", 30), students);

            //when
            string actual = classTested.Students[0].Introduce();

            //then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_String_Contains_Name_Age_Teacher_And_Class_When_A_Teacher_With_Class_Introduce()
        {
            //given
            string expected = "My name is Amy. I am 30 years old. I am a teacher of class 2.";
            var students = new List<Student> { new Student("Tom", 18) };
            var classTested = new Class(2, new Teacher("Amy", 30), students);

            //when
            string actual = classTested.Teacher.Introduce();

            //then
            Assert.Equal(expected, actual);
        }

        //AC4
        [Fact]
        public void Should_Teacher_And_Student_Say_When_New_Student_Join()
        {
            //given
            string expected = "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.";
            var students = new List<Student>();
            var classTested = new Class(2, new Teacher("Amy", 30), students);
            //when
            string actual = classTested.AddStudent(new Student("Tom", 18));
            //then
            Assert.Equal(expected, actual);
        }
}
}
