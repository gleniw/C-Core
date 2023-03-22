using NUnit.Framework;
using System.Diagnostics;

namespace AdvancedNUnit
{
    [TestFixture]
    //[Ignore("Not using these tests yet")]


    public class CounterTests
    {
        [SetUp]
        //SETUP IS RAN BEFORE EACH TEST METHOD - INSTANTIATE A NEW COUNTER
        //ONE TIME SETUP IS AT THE BEGGINING NOT BEFORE EVERY INDIVIDUAL TEST - INSTANTIATE A NEW COUNTER

        public void SetUp()
        {
            _sut = new Counter(6);

        }

        private Counter _sut = new Counter(6);

        [Test]
        public void Increment_IncreaseCountByOne()
        {
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }

        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }

        [TearDown]

        //TEARDOWN After each method
        //ONE TIME TEARDOWN after all methods
        public void TearDown()
        {
            Debug.WriteLine("Tear me down");
        }

        //Principles of Unit Testing
    }
}
