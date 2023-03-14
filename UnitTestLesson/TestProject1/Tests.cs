using CodeTest;

namespace TestProject1
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            // Arrange - Pre - Condition
            var time = 21;
            var expectedGreeting = "Good Evening";
            // Act - When
            var result = Program.Greeting(time);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodMorning()
        {
            // Arrange - Pre - Condition
            var time = 11;
            var expectedGreeting = "Good Morning";
            // Act - When
            var result = Program.Greeting(time);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodAfternoon()
        {
            // Arrange - Pre - Condition
            var time = 17;
            var expectedGreeting = "Good Afternoon";
            // Act - When
            var result = Program.Greeting(time);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}