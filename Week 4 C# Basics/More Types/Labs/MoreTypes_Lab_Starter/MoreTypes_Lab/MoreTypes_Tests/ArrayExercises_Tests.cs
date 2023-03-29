using MoreTypes_Lib;
using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace MoreTypes_Tests
{
    class ArrayExercises_Tests
    {
        private List<string> _list = new List<string>{ "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta" }; 
        [Test]
        public void GivenAListOfStrings_Make1DArray_ReturnsAnArrayOfTheSameStrings()
        {
            string[] result = ArraysExercises.Make1DArray(_list);
            Assert.That(result.Length, Is.EqualTo(6), "Length incorrect");
            Assert.That(result[0], Is.EqualTo("Alpha"), "First element incorrect");
            Assert.That(result[1], Is.EqualTo("Beta"), "Second element incorrect");
            Assert.That(result[2], Is.EqualTo("Gamma"), "Third element incorrect");
            Assert.That(result[3], Is.EqualTo("Delta"), "Fourth element incorrect");
            Assert.That(result[4], Is.EqualTo("Epsilon"), "Fifth element incorrect");
            Assert.That(result[5], Is.EqualTo("Zeta"), "Last element incorrect");
        }
    }
}
