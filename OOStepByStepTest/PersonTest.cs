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
    }
}
