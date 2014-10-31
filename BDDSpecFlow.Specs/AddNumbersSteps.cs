using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDSpecFlow.Specs
{
    [Binding]
    public class AddNumbersSteps
    {

        private int _result = 0; 

        [Given(@"I have cleared the calculator")]
        public void GivenIHaveClearedTheCalculator()
        {
            //ScenarioContext.Current.Pending();
            //Assert.
            _result = 0;
        }

        [When(@"I enter (.*)")]
        public void WhenIEnter(int p0)
        {
            //ScenarioContext.Current.Pending();
            _result = p0;
        }

        [When(@"I add (.*)")]
        public void WhenIAdd(int p0)
        {
            //ScenarioContext.Current.Pending();
            _result += p0;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            ScenarioContext.Current.Pending();
            //Assert.AreEqual(_result, expected);
        }
    }
}
