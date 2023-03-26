using NUnit.Framework;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        //[Category("Sad Path")]
        //Use above to categorise and filter when test have been run


        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [Test]
        public void SomeConstraints()
        {
            var subject = new Calculator { Num1 = 6 };
            Assert.That(subject.DivisibleBy3);
            subject.Num1 = 7;
            Assert.That(subject.DivisibleBy3(), Is.False);
            var calcString = subject.ToString();
            Assert.That(subject.ToString(), Does.Contain("Calculator"));
        }

        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            var calcString = subject.ToString();
            Assert.That(calcString, Does.Not.Contain("Lucas"));
            Assert.That(calcString, Is.EqualTo("advancedunit.calculator"));
            Assert.That(calcString, Is.EqualTo("advancedunit.calculator").IgnoreCase);
            Assert.That(calcString, Is.Not.Empty);

        }

        [Test]

        public void CollectionConstraints()
        {
            var trainees = new List<string> { "Ali", "Glen", "Suheyb", "Sam" };
            Assert.That(trainees, Does.Contain("Ali"));
            Assert.That(trainees, Does.Contain("ali").IgnoreCase);
            Assert.That(trainees, Has.Count.EqualTo(4));
            Assert.That(trainees, Has.Exactly(2).StartsWith("S"));
        }

        [Test]
        public void ConstraintAssertionModel()
        {
            var list = new List<int> { 1, 2, 3, };
            //Assert.AreEquals(1, list.Where(x => x== 4).Count());
            Assert.That(list, Has.Exactly(1).EqualTo(4));
            Assert.That(list, Has.Count.AtLeast(1));

            // IS DOES HAS AND CHECK AVALIABLE METHODS
        }

        [Test]
        public void TestRange()
        {
            Assert.That(8, Is.InRange(1, 10));
            var list = new List<int> { 4, 2, 7, 5, 9 };
            Assert.That(list, Is.All.InRange(1, 10));
            Assert.That(list, Has.Exactly(3).InRange(1, 5));
        }

        //[Test]
        //public void GlenPracticeTests()
        //{
        //    var list1 = new List<string> { "Spurs", "Arsenal", "Man City", "Man United" };
        //    var list2 = new List<int> { 4, 2, 7, 5, 9 };

        //    Assert.That(list1, Is.TypeOf(string));
        //    Assert.That(list1, Has.Exactly("Spurs"));
        //    Assert.That(list2, Does.Contain("1"));
        //}

        //[TestCase(2, 4, 6)]
        //[TestCase(-2, 3, 1)]

        //public void Add_Always_Returns_Expected_Result(int num1, int num2, int exp)
        //{
        //    var subject = new Calculator { Num1 = num1, Num2 = num2 };
        //    Assert.That(subject.Add(), Is.EqualTo(exp));
        //}

        [TestCaseSource("AddCases")]

        public void Add_Always_Returns_Expected_Result(int num1, int num2, int exp)
        {
            var subject = new Calculator { Num1 = num1, Num2 = num2 };
            Assert.That(subject.Add(), Is.EqualTo(exp));
        }

        private static int[][] AddCases =
        {
            new int[]{2,4,6},
            new int []{-2,3,1}
        };

    }
}