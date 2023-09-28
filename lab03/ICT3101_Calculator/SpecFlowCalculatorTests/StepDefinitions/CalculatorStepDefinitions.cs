using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Addition")]
    public sealed class UsingCalculatorStepDefinitionsAddition
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsAddition(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }
        
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculatorContext._calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}