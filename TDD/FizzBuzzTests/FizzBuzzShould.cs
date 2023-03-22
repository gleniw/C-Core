using FizzBuzzApp;
namespace FizzBuzzTests
{
    public class Tests
    {
        [Test]
        public void GivenOne_Return_OneString()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void GivenANumber_Return_ItsString(int input, string expOutput)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expOutput));
        }

        //

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void GivenANumberDivisableBy3_Return_Fizz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void GivenANumberDivisableBy5_Return_Buzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        public void GivenANumberDivisibleByThreeAndFive_Return_FizzBuzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("FizzBuzz"));
        }
    }
}