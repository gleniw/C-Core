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
        public void GivenATimeOf11_Greeting_ReturnsGoodMorning()
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
        public void GivenATimeOf17_Greeting_ReturnsGoodAfternoon()
        {
            // Arrange - Pre - Condition
            var time = 17;
            var expectedGreeting = "Good Afternoon";
            // Act - When
            var result = Program.Greeting(time);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [Test]
        public void GivenATimeOf17_Greeting_ReturnsGoodAfternoonGlen()
        {
            // Arrange - Pre - Condition
            var time = 17;
            var expectedGreeting = "Good Afternoon Glen";
            // Act - When
            var result = Program.Greeting(time);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [Test]
        public void GivenATimeOfNegative5_Greeting_ReturnsVoid()
        {
            // Arrange - Pre - Condition
            var time = -5;
            var expectedGreeting = "Void";
            // Act - When
            var result = Program.Greeting(time);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(5)]
        [TestCase(11)]
        [TestCase(8)]
        public void GivenATimeLessThan12_MoreThan5_Greeting_ReturnsGoodMorning(int timeOfDay)
        {

            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good Morning"));
        }

        [TestCase(12)]
        [TestCase(18)]
        [TestCase(15)]
        public void GivenATimeMoreThan12_LessThan18_Greeting_ReturnsGoodAfternoon(int timeOfDay)
        {

            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good Afternoon"));
        }

        [TestCase(18)]
        [TestCase(00)]
        [TestCase(21)]
        public void GivenATimeMoreThan18_LessThan00_Greeting_ReturnsGoodEvening(int timeOfDay)
        {

            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good Evening"));
        }

        [TestCase(-5)]
        [TestCase(123)]
        [TestCase(1*1)]
        [TestCase(9000000)]
        public void GivenATime_ReturnsInvalidEntry(int timeOfDay)
        {

            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Invalid Entry"));
        }

    }
}