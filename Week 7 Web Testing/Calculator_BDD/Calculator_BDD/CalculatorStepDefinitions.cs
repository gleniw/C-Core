using System;
using TechTalk.SpecFlow;
using CalculatorLib;

namespace Calculator_BDD
{
    [Binding] //Bound to a feature file called calculator
    public class CalculatorStepDefinitions
    {
        private Calculator _calculator;
        private int _result;
        private Exception _exception;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }


        [Given(@"I enter (.*) and (.*) into the calculator")]
        public void GivenIEnterAndIntoTheCalculator(int a, int b)
        {
            _calculator.Num1 = a;
            _calculator.Num2 = b;

        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }


        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result = _calculator.Subtract();
        }


        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            _result = _calculator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            try
            {
                _result = _calculator.Divide();
            }
            catch (DivideByZeroException e)
            {
                _exception = e;
            }

        }

        #region Exercise 2

        [Then(@"a DivideByZero Exception should a DivideByZeroException when I press divide")]
        public void ThenADivideByZeroExceptionShouldADivideByZeroExceptionWhenIPressDivide()
        {
            try
            {
                _result = _calculator.Divide();
            }
            catch (DivideByZeroException e)
            {
                _exception = e;
            }

        }

        [Then(@"the exception should have the message ""([^""]*)""")]
        public void ThenTheExceptionShouldHaveTheMessage(string expectedMessage)
        {
            Assert.That(_exception.Message, Is.EqualTo(expectedMessage));
        }
        #endregion

        #region Exercise 3

        //[Given(@"I enter the numbers below to a list")]
        //public void GivenIEnterTheNumbersBelowToAList(Table table)
        //{
        //    List<int> nums = new List<int>();
        //    foreach (var num in table.Rows)
        //    {
        //        nums.Add(int.Parse(num["nums"]));
        //    }
        //}

        //[When(@"I iterate through the list to add all the even numbers")]
        //public void WhenIIterateThroughTheListToAddAllTheEvenNumbers()
        //{
        //    _result = _calculator.SumOfNumbersDivisibleBy2(nums);
        //}

        #endregion

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

    }
}
