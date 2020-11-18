namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var student = new Student("Tom", 21);
            //given
            string expected = "My name is Tom. I am 21 years old";

            //when
            string actual = student.Introduce();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
