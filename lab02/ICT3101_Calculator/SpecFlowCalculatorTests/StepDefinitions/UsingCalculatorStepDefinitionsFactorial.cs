using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Factorial")]
    public sealed class UsingCalculatorStepDefinitionsFactorial 
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsFactorial(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }
        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0)
        {
            try
            {
                _result = _calculatorContext._calculator.Factorial(p0);
            }
            catch (ArgumentException ex)
            {
                _error = ex.Message;
            }
        }
        [Then(@"the factorial result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            Assert.That(_error, Is.EqualTo(p0));
        }
    }
}