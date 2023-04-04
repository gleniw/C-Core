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
            _result = _calculator.Divide();
        }



        [Then(@"a DivideByZero Exception should a DivideByZeroException when I press divide")]
        public void ThenADivideByZeroExceptionShouldADivideByZeroExceptionWhenIPressDivide()
        {
            _result = _calculator.Divide();
        }

        [Then(@"the exception should have the message ""([^""]*)""")]
        //public void ThenTheExceptionShouldHaveTheMessage(string expectedMessage)
        //{
        //    try
        //    {
        //        _calculator.Divide();
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Assert.AreEqual(expectedMessage, e.Message);
        //    }
        //}

        public void ThenADivideByZeroExceptionShouldADivideByZeroExceptionWhenIPressDivide()
        {
            try 
            {
                _result = _calculator.Divide();
                Assert.Fail("Expected DivideByZeroException was not thrown"); } catch (DivideByZeroException e) { Assert.AreEqual("Cannot Divide By Zero", e.Message); } }



        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

    }
}
