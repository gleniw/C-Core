using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {

        //POWERS
        [TestCase(10, 100, 1000,3.162)]

        public void GivenANumber_Squared_Cubed_And_SquareRoot_Calculations_ReturnsCorrectTuple
            
            (int inputNumber, int expectedSquaredNumber, int expectedCubedNumber, double expectedSquareRootNumber)
        {
            var answer = Methods.PowersRoot(inputNumber);
            Assert.That(answer.squared, Is.EqualTo(expectedSquaredNumber), "Squared");
            Assert.That(answer.cubed, Is.EqualTo(expectedCubedNumber), "Cubed");
            Assert.That(answer.squareRoot, Is.EqualTo(expectedSquareRootNumber), "Square Root");
        }

        //Roll Dice

        //[TestCase(12)]

        //public void GivenANumber_SumOfRollDiceReturnsSumLessThanThirteen (Random rng)
        //{
        //    var maximumNumber = 13;
        //    var answer = Methods.RollDice(rng);
        //    Assert.That(answer.rng, Is.EqualTo(maximumNumber));
        //}


    }
}
