﻿using System;
using TechTalk.SpecFlow;
using myFirstCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTestProj
{

    [Binding]
    public class CalculatorSteps
    {
        private Calculator calc = new Calculator();
        private int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calc.operand1 = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calc.operand2 = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calc.add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
