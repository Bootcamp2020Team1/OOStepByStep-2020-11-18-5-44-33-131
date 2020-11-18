namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class StudentTest
    {
        [Fact]
        public void TestStudent()
        {
            var student = new Student("Tom", 18);
            //given
            string expected = "My name is Tom. I am 18 years old. I am a student";

            //when
            string actual = student.Introduce();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
