using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Tag = "AverageNumberOfFailures")]
    public sealed class UsingCalculatorStepDefinitionsAverageNumberOfFailures
    {
        
        private readonly CalculatorContext _calculatorContext;

        private double _result;
        private string _error;

        public UsingCalculatorStepDefinitionsAverageNumberOfFailures(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }

        [When(@"I have entered (.*), (.*), (.*) into the calculator and press Average number of expected failures")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1, double p2)
        {
            try{
                _result = _calculatorContext._calculator.AverageNumberOfFailures(p0, p1, p2);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        [When(@"I have entered (.*), (.*), (.*) into the calculator and press Logarithmic Average number of expected failures")]
        public void WhenIHaveEnteredAndIntoTheCalculator2(double p0, double p1, double p2)
        {
            try{
                _result = _calculatorContext._calculator.LogarithmicAverageNumberOfFailures(p0, p1, p2);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        [Then(@"the average number of expected failures result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        [Then(@"the average number of expected failures result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen2(string p0)
        {
            Assert.That(_error, Is.EqualTo(p0));
        }
    }

    [Binding]
    [Scope(Tag = "LogarithmicAverageNumberOfFailures")]
    public sealed class UsingCalculatorStepDefinitionsLogarithmicAverageNumberOfFailures
    {
        
        private readonly CalculatorContext _calculatorContext;

        private double _result;
        private string _error;

        public UsingCalculatorStepDefinitionsLogarithmicAverageNumberOfFailures(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }

        [When(@"I have entered (.*), (.*), (.*) into the calculator and press Logarithmic Average number of expected failures")]
        public void WhenIHaveEnteredAndIntoTheCalculator2(double p0, double p1, double p2)
        {
            try{
                _result = _calculatorContext._calculator.LogarithmicAverageNumberOfFailures(p0, p1, p2);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        [Then(@"the average number of expected failures result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        [Then(@"the average number of expected failures result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen2(string p0)
        {
            Assert.That(_error, Is.EqualTo(p0));
        }
    }
}