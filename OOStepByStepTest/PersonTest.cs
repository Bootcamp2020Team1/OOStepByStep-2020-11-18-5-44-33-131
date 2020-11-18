using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
    public class PersonTest
    {
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
    }
}
