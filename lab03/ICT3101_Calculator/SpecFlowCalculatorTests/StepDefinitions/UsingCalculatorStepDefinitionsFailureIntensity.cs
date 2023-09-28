using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Tag = "FailureIntensity")]
    public sealed class UsingCalculatorStepDefinitionsFailureIntensity
    {
        
        private readonly CalculatorContext _calculatorContext;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsFailureIntensity(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }
        [When(@"I have entered (.*), (.*), (.*) into the calculator and press Failure Intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1, double p2)
        {
            try{
                _result = _calculatorContext._calculator.FailureIntensity(p0, p1, p2);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        [Then(@"the Failure Intensity result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        [Then(@"the Failure Intensity result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen2(string p0)
        {
            Assert.That(_error, Is.EqualTo(p0));
        }
    }

    [Binding]
    [Scope(Tag = "LogarithmicFailureIntensity")]
    public sealed class UsingCalculatorStepDefinitionsLogarithmicFailureIntensity
    {
        
        private readonly CalculatorContext _calculatorContext;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsLogarithmicFailureIntensity(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }
        [When(@"I have entered (.*), (.*), (.*) into the calculator and press Logarithmic Failure Intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1, double p2)
        {
            try{
                _result = _calculatorContext._calculator.LogarithmicFailureIntensity(p0, p1, p2);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        [Then(@"the Failure Intensity result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        [Then(@"the Failure Intensity result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen2(string p0)
        {
            Assert.That(_error, Is.EqualTo(p0));
        }
    }
}