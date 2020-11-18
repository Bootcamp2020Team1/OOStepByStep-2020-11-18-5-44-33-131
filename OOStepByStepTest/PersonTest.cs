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
    }
}
