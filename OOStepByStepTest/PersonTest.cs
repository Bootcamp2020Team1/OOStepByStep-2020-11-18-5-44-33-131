namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_introduce_from_person()
        {
            //given
            var person = new Person("Tom", 21);
            //when
            var actual = person.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", actual);
        }

        [Fact]
        public void Should_introduce_from_student()
        {
            //given
            var student = new Student("Tom", 18, new Class2());
            //when
            var actual = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", actual);
        }

        [Fact]
        public void Should_introduce_from_teacher()
        {
            //given
            var teacher = new Teacher("Amy", 30, new Class2());
            //when
            var actual = teacher.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", actual);
        }
    }
}
