using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Availability")]
    public sealed class UsingCalculatorStepDefinitionsAvailablity
    {
        
        private readonly CalculatorContext _calculatorContext;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsAvailablity(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }
        

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            try{
                _result =  _calculatorContext._calculator.MTBF(p0, p1);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        
        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculator2(double p0, double p1)
        {
            try{
                _result = _calculatorContext._calculator.Availability(p0, p1);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        [Then(@"the MTBF result should be ""(.*)""")]
        public void TheResultWhenMTBFArguementsAreInvalid(string p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen2(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen2(string p0)
        {
            Assert.That(_error, Is.EqualTo(p0));
        }

    }
}