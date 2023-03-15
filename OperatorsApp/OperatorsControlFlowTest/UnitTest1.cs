using Microsoft.VisualStudio.TestPlatform.TestHost;
using OperatorsApp;

namespace OperatorsControlFlowTest
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

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
    }
}