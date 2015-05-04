using App.Code;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDSpecFlow.Specs
{
    [Binding]
    public class SimpleCalculatorSteps
    {
        SimpleCalculator calc = new SimpleCalculator();

        int num1 = 0;
        int num2 = 0;
        int result = 0;
                
        [Given(@"the first number is ""(.*)""")]
        public void GivenTheFirstNumberIs(int p0)
        {
            num1 = p0;            
        }

        [Given(@"the second number is ""(.*)""")]
        public void GivenTheSecondNumberIs(int p0)
        {
            num2 = p0;
        }

        [When(@"I use Subtract in the calculator")]
        public void WhenIUseSubtractInTheCalculator()
        {
            result = calc.Sub(num1, num2);
        }

        [When(@"I use Multiply in the calculator")]
        public void WhenIUseMultiplyInTheCalculator()
        {
            result = calc.Multiply(num1, num2);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(p0, result);
        }
    }
}
