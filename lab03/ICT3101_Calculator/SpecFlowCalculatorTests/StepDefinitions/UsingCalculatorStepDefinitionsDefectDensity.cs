using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Tag = "DefectDensity")]
    public sealed class UsingCalculatorStepDefinitionsDefectDensity
    {
        
        private readonly CalculatorContext _calculatorContext;

        private double _result;
        private string _error;

        public UsingCalculatorStepDefinitionsDefectDensity(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }

        [When(@"I have entered (.*), (.*) into the calculator and press Defect Density")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            try{
                _result = _calculatorContext._calculator.DefectDensity(p0, p1);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        [Then(@"the defect density result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        [Then(@"the defect density result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen2(string p0)
        {
            Assert.That(_error, Is.EqualTo(p0));
        }
    }
}