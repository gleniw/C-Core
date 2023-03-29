using ExceptionsLabExercises;
using NUnit;
//using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace GradeExceptionTesting
{
    public class Tests
    {

        #region Greeting Tests

        //Testing Greeting Values

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

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(11)]
        public void GivenATimeLessThan12_MoreThan5_Greeting_ReturnsGoodMorning(int timeOfDay)
        {

            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good Morning"));
        }

        //[Ignore "Suppose to fail"]
        //[Category("Fail Test")]
        //*Example of if you want to ignore a test */

        [TestCase(12)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenATimeMoreThan12_LessThan18_Greeting_ReturnsGoodAfternoon(int timeOfDay)
        {

            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good Afternoon"));
        }

        [TestCase(19)]
        [TestCase(20)]
        [TestCase(23)]
        public void GivenATimeMoreThan18_LessThan00_Greeting_ReturnsGoodEvening(int timeOfDay)
        {

            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good Evening"));
        }


        [TestCase(11, "Good Morning")]
        [TestCase(12, "Good Afternoon")]
        [TestCase(19, "Good Evening")]

        public void GivenANumber(int time, string expected)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo(expected));
        }

        //Testing Exceptions

        [TestCase(-10)]
        [TestCase(-15)]
        public void WhenATimeIsLessThanZero_ThrowsAnArguementOutOfRangeException(int time)
        {
            Assert.That(() => Program.Greeting(time), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("Allowed Range 1-24 (where 1 = 1:00AM and 24 = 00:00"));
        }

        [TestCase(25)]
        [TestCase(30)]
        public void WhenATimeMoreThanTwentyFour_ThrowsAnArguementOutOfRangeException(int time)
        {
            Assert.That(() => Program.Greeting(time), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("Allowed Range 1-24 (where 1 = 1:00AM and 24 = 00:00"));
        }

        #endregion
    }
}