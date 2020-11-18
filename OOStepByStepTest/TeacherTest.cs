using OOStepByStep;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOStepByStepTest
{
    public class TeacherTest
    {
        [Fact]
        public void TestTeacher()
        {
            var teacher = new Teacher("Amy", 30, 2);
            //given
            string expected = "My name is Amy. I am 30 years old. I am a teacher of class 2";

            //when
            string actual = teacher.Introduce();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
