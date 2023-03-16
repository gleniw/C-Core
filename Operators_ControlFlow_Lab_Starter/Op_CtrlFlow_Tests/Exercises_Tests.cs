//using Microsoft.VisualStudio.TestPlatform.TestHost;
//using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        #region

        //Average Method Exception Tests

        //[TestCase()]
        //public void WhenAListIsEmpty_ThrowsAnArguementOutOfRangeException(List<int> nums)
        //{
        //    Assert.That(() => Exercises.Average(nums), Throws.TypeOf<ArgumentNullException>()
        //    .With.Message.Contain("List cannot be empty"));
        //}

        //Ticket Type Exception Tests
       
        [TestCase(-10)]
        [TestCase(-15)]
        public void WhenAgeIsLessThanZero_ThrowsAnArguementOutOfRangeException(int age)
        {
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("Allowed Range 0-120"));
        }

        [TestCase(125)]
        [TestCase(130)]
        public void WhenAgeIsMoreThanOneHundredAndTwenty_ThrowsAnArguementOutOfRangeException(int age)
        {
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("Allowed Range 0-120"));
        }

        //Grade Exception Tests

        [TestCase(-10)]
        [TestCase(-15)]
        public void WhenGradeIsLessThanZero_ThrowsAnArguementOutOfRangeException(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("You can only score between 0-100"));
        }

        [TestCase(125)]
        [TestCase(130)]
        public void WhenGradeIsMoreThanOneHundred_ThrowsAnArguementOutOfRangeException(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("You can only score between 0-100"));
        }

        //GetScottishMaxWeddingNumbers Exception Tests

        [TestCase(5)]
        [TestCase(6)]
        public void WhenCovidLevelIsInvalid_ThrowsAnArguementOutOfRangeException(int covidlevel)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(covidlevel), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("Maximum amount of people entry is 200"));
        }

        #endregion

        // write unit test(s) for MyMethod here

        [Test]
        public void TestIfCompareNumber1Value10_Number2Value10_EqualsFalseWhereRemainerIsZero()
        {
            //Values are the same, Remainder is zero
            // Arrange - Pre - Condition
            var int1Result = 10;
            var int2Result = 10;
            bool expectedResult = false;
            // Act - When
            var result = Exercises.MyMethod(int1Result,int2Result);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestIfCompareNumber1Value20_Number2Value10_EqualsTrueWhereRemainerIsNotZero()
        {
            //Values are different, Remainder is zero
            // Arrange - Pre - Condition
            var int1Result = 20;
            var int2Result = 10;
            bool expectedResult = true;
            // Act - When
            var result = Exercises.MyMethod(int1Result, int2Result);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestIfCompareNumber1Value30_Number2Value20_EqualsFalseWhereRemainerIsNotZero()
        {
            //Values are different, Remainder is not zero
            // Arrange - Pre - Condition
            var int1Result = 30;
            var int2Result = 20;
            bool expectedResult = false;
            // Act - When
            var result = Exercises.MyMethod(int1Result, int2Result);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        //[Test]
        //public void WhenListIsEmpty_Average_ReturnsZero()
        //{
        //    var myList = new List<int>() {};
        //    Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        //}

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }


        //[TestCase(4, 4)]
        //[TestCase(3,3)]
        //[TestCase(2,2)]
        //[TestCase(1,1)]
        //[TestCase(0,0)]
        //public void TestForNoOfPeopleToShowWarningLevel(int covidLevel, int expectedResult)
        //{

        //    Assert.That(Exercises.GetScottishMaxWeddingNumbers(covidLevel), Is.EqualTo(expectedResult));
        //}

        [Test]
        public void TestForNoOfPeopleEqualto20ToShowWarningLevel4()
        {
            // Arrange - Pre - Condition
            var noOfAttendees = 20;
            var expectedCovidLevel = 4;
            // Act - When
            var result = Exercises.GetScottishMaxWeddingNumbers(noOfAttendees);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedCovidLevel));
        }

        [Test]
        public void TestForNoOfPeopleEqualto30ToShowWarningLevel3()
        {
            // Arrange - Pre - Condition
            var noOfAttendees = 30;
            var expectedCovidLevel = 3;
            // Act - When
            var result = Exercises.GetScottishMaxWeddingNumbers(noOfAttendees);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedCovidLevel));
        }

        [Test]
        public void TestForNoOfPeopleEqualto50ToShowWarningLevel2()
        {
            // Arrange - Pre - Condition
            var noOfAttendees = 50;
            var expectedCovidLevel = 2;
            // Act - When
            var result = Exercises.GetScottishMaxWeddingNumbers(noOfAttendees);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedCovidLevel));
        }

        [Test]
        public void TestForNoOfPeopleEqualto100ToShowWarningLevel1()
        {
            // Arrange - Pre - Condition
            var noOfAttendees = 100;
            var expectedCovidLevel = 1;
            // Act - When
            var result = Exercises.GetScottishMaxWeddingNumbers(noOfAttendees);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedCovidLevel));
        }

        [Test]
        public void TestForNoOfPeopleEqualto200ToShowWarningLevel0()
        {
            // Arrange - Pre - Condition
            var noOfAttendees = 100;
            var expectedCovidLevel = 1;
            // Act - When
            var result = Exercises.GetScottishMaxWeddingNumbers(noOfAttendees);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedCovidLevel));
        }

        [Test]
        public void TestIfStudentGrade100IsDistinction()
        {
            // Arrange - Pre - Condition
            var studentResult = 100;
            var expectedGrade = "Pass with Distinction";
            // Act - When
            var result = Exercises.Grade(studentResult);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGrade));
        }

        [Test]
        public void TestIfStudentGrade74IsMerit()
        {
            // Arrange - Pre - Condition
            var studentResult = 74;
            var expectedGrade = "Pass with Merit";
            // Act - When
            var result = Exercises.Grade(studentResult);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGrade));
        }

        [Test]
        public void TestIfStudentGrade59IsPass()
        {
            // Arrange - Pre - Condition
            var studentResult = 59;
            var expectedGrade = "Pass";
            // Act - When
            var result = Exercises.Grade(studentResult);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGrade));
        }

        [Test]
        public void TestIfStudentGrade39IsAFail()
        {
            // Arrange - Pre - Condition
            var studentResult = 39;
            var expectedGrade = "Fail";
            // Act - When
            var result = Exercises.Grade(studentResult);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGrade));
        }
    }
}
