using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Tag = "NewSSI")]
    public sealed class UsingCalculatorStepDefinitionsNewSSI
    {
        
        private readonly CalculatorContext _calculatorContext;

        private double _result;
        private string _error;

        public UsingCalculatorStepDefinitionsNewSSI(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }

        [When(@"I have entered (.*), (.*), (.*), (.*) into the calculator and press New SSI")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1, double p2, double p3)
        {
            try{
                _result = _calculatorContext._calculator.NewSSI(p0, p1, p2, p3);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        [Then(@"the new SSI result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        [Then(@"the new SSI result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen2(string p0)
        {
            Assert.That(_error, Is.EqualTo(p0));
        }
    }
}