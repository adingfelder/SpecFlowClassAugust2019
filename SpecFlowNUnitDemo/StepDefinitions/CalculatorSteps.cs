using System;
using TechTalk.SpecFlow;
using MyNewCalculator;
using NUnit.Framework;



namespace SpecFlowNUnitDemo.StepDefinitions
{
    [Binding]
    public class CalculatorSteps
    {

        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numEntered)
        {
            Console.WriteLine("doing GivenIHaveEnteredIntoTheCalculator");
            calculator.numbers.Add(numEntered);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            Console.WriteLine("doing WhenIPressSubtract");
            calculator.Subtract();
            //ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("doing WhenIPressAdd");
            calculator.Add();
            //ScenarioContext.Current.Pending();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            calculator.Divide();
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Console.WriteLine("doing ThenTheResultShouldBeOnTheScreen");
            Assert.AreEqual(expectedResult, calculator.total);
            //ScenarioContext.Current.Pending();
        }
    


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(float expectedResult)
        {
            Console.WriteLine("doing ThenTheResultShouldBeOnTheScreen");
            Assert.AreEqual(expectedResult, calculator.total);
            //ScenarioContext.Current.Pending();
        }
    }
}
