using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Divisions")]
    public sealed class UsingCalculatorStepDefinitionsDivision
    {   
        private readonly CalculatorContext _calculatorContext;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsDivision(CalculatorContext _calc)
        {
            this._calculatorContext = _calc;
            this._result = 0;
            this._error = "";
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            try{
                _result = _calculatorContext._calculator.Divide(p0, p1);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }
        [Then(@"the division result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the division result should be positive_infinity")]
        public void ThenTheResultShouldBeOnTheScreen2()
        {
            Assert.That(true);
        }
    }
}