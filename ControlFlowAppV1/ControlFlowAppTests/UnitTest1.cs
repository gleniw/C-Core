using Microsoft.VisualStudio.TestPlatform.TestHost;
using ControlFlowAppV1;
using NUnit.Framework;
using Program = ControlFlowAppV1.Program;

namespace ControlFlowAppTests
{
    public class Tests
    {
        [Test]
        public void TestIfStudentGradeOf65IsPass()
        {
            // Arrange - Pre - Condition
            var studentResult = 65;
            var expectedGrade = "Pass";
            // Act - When
            var result = Program.Grade(studentResult);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGrade));
        }

        [TestCase(65)]
        [TestCase(76)]
        [TestCase(84)]
        public void TestIfMultipleStudentGradesArePass(int mark)
        {

            Assert.That(Program.Grade(mark), Is.EqualTo("Pass"));
        }

        [Test]
        public void TestIfStudentGrade85IsDistinction()
        {
            // Arrange - Pre - Condition
            var studentResult = 85;
            var expectedGrade = "Distinction";
            // Act - When
            var result = Program.Grade(studentResult);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGrade));
        }


        [TestCase(85)]
        [TestCase(95)]
        [TestCase(100)]
        public void TestIfMultipleStudentGradesAreDistinction(int mark)
        {

            Assert.That(Program.Grade(mark), Is.EqualTo("Distinction"));
        }

        [Test]
        public void TestIfStudentGrade20IsFail()
        {
            // Arrange - Pre - Condition
            var studentResult = 20;
            var expectedGrade = "Fail";
            // Act - When
            var result = Program.Grade(studentResult);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedGrade));
        }

        [TestCase(0)]
        [TestCase(30)]
        [TestCase(64)]
        public void TestIfMultipleStudentGradesAreFail(int mark)
        {

            Assert.That(Program.Grade(mark), Is.EqualTo("Fail"));
        }


        //Alternative example below

        [Test]

        [TestCase(0, "Fail")]
        [TestCase(65, "Pass")]
        [TestCase(85, "Distinction")]
        public void TestIfMultipleStudentGradesAreFail(int mark, string expectedResult)
        {

            Assert.That(Program.Grade(mark), Is.EqualTo(expectedResult));
        }
    }
}