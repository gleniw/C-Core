using OperatorsControlFlowLab;
namespace OperatorsControlFlowExceptionTesting
{
    public class Tests
    {
        #region

        [Test]
        public void GivenAPoundsWeightOf156__ReturnsAStonesWeightof11()
        {
            // Arrange - Pre - Condition
            var weight = 156;
            var expectedWeight = 11;
            // Act - When
            var result = Method.GetStones(weight);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedWeight));
        }

        [Test]
        public void GivenAPoundsWeightOf90__ReturnsAStonesWeightof6()
        {
            // Arrange - Pre - Condition
            var weight = 90;
            var expectedWeight = 6;
            // Act - When
            var result = Method.GetStones(weight);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedWeight));
        }

        [Test]
        public void GivenAPoundsWeightOf156APoundsRemainderReturns2Pounds()
        {
            // Arrange - Pre - Condition
            var weight = 156;
            var expectedWeight = 2;
            // Act - When
            var result = Method.GetPounds(weight);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedWeight));
        }

        [Test]
        public void GivenAPoundsWeightOf90APoundsRemainderReturn6Pounds()
        {
            // Arrange - Pre - Condition
            var weight = 90;
            var expectedWeight = 6;
            // Act - When
            var result = Method.GetPounds(weight);
            // Assert  - Then
            Assert.That(result, Is.EqualTo(expectedWeight));
        }


        //TESTING EXCEPTIONS

        [TestCase(-90)]
        [TestCase(-156)]
        public void WhenWeightIsLessThanANegativeValue_ThrowsAnArguementOutOfRangeException(int weight)
        {
            Assert.That(() => Method.GetStones(weight), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain("Cannot enter a negative value"));
        }

        #endregion
    }
}