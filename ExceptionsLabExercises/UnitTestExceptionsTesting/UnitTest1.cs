using UnitTestExceptionsLabExercises;
namespace UnitTestExceptionsTesting
{
    public class Tests
    {
        #region Classification Tests

        //SINGLE VALUE TESTS
        [Test]
        public void GivenAnAgeOf11_Result_Returns_U_PG_12()
        {
            // Arrange - Pre - Condition
            var age = 11;
            var expectedResult = "U, PG & 12 films are available.";
            // Act - When
            var result = Program.Classification(age);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAnAgeOf14_Result_Returns_U_PG_12_15()
        {
            // Arrange - Pre - Condition
            var age = 14;
            var expectedResult = "U, PG, 12 & 15 films are available.";
            // Act - When
            var result = Program.Classification(age);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAnAgeOf18_Result_Returns_AllFilmsAvaliable()
        {
            // Arrange - Pre - Condition
            var age = 18;
            var expectedResult = "All films are available.";
            // Act - When
            var result = Program.Classification(age);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        ///MULTI VALUE TESTS

        [TestCase(1)]
        [TestCase(6)]
        [TestCase(11)]
        public void GivenAnAgeLessThan12_Result_Returns_U_PG_12(int ageOfViewer)
        {
            Assert.That(Program.Classification(ageOfViewer), Is.EqualTo("U, PG & 12 films are available."));
        }


        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        public void GivenAnAgeBetween12And15_Result_Returns_U_PG_12_15(int ageOfViewer)
        {
            Assert.That(Program.Classification(ageOfViewer), Is.EqualTo("U, PG, 12 & 15 films are available."));
        }

        [TestCase(18)]
        [TestCase(59)]
        [TestCase(100)]
        public void GivenAnAgeAbove18_Result_Returns_AllFilmsAvaliable(int ageOfViewer)
        {
            Assert.That(Program.Classification(ageOfViewer), Is.EqualTo("All films are available."));
        }

        //Testing Exceptions

        [TestCase(-10)]
        [TestCase(-15)]
        public void WhenAgeIsLessThanZero_ThrowsAnArguementOutOfRangeException(int age)
        {
            Assert.That(() => Program.Classification(age), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("Allowed Range 0-120"));
        }

        [TestCase(125)]
        [TestCase(130)]
        public void WhenAgeIsMoreThanOneHundredAndTwenty_ThrowsAnArguementOutOfRangeException(int age)
        {
            Assert.That(() => Program.Classification(age), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("Allowed Range 0-120"));
        }
        #endregion
    }
}