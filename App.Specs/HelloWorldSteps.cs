using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDSpecFlow.Specs
{
    [Binding]
    public class HelloWorldSteps
    {
        string name ="";
        string message = "";
        
        [Given(@"I have entered my name ""(.*)""")]
        public void GivenIHaveEnteredMyName(string inputName)
        {
            name = inputName; 
        }

        [When(@"I press Say Hello")]
        public void WhenIPressSayHello()
        {
            message = "Hello " + name + "!";
        }

        [Then(@"The screen displays ""(.*)""")]
        public void ThenTheScreenDisplays(string outputMessage)
        {
            Assert.AreEqual(outputMessage, message);
        }
    }
}
