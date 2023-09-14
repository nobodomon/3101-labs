using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{

    //Context injection


    [Binding]
    [Scope(Tag = "Addition")]
    public sealed class UsingCalculatorStepDefinitionsAddition
    {
        private Calculator _calculator;
        private double _result;
        public UsingCalculatorStepDefinitionsAddition(Calculator calc)
        {
            this._calculator =  calc;
            this._result = 0;
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {

        }
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }

    // For division

    [Binding]
    [Scope(Tag = "Divisions")]
    public sealed class UsingCalculatorStepDefinitionsDivision
    {
        private Calculator _calculator;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsDivision(Calculator calc)
        {
            this._calculator =  calc;
            this._result = 0;
            this._error = "";
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            try{
                _result = _calculator.Divide(p0, p1);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }
        [Then(@"the division result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen2(string p0)
        {
            Assert.That(_error, Is.EqualTo(p0));
        }
    }

    [Binding]
    [Scope(Tag = "Factorial")]
    public sealed class UsingCalculatorStepDefinitionsFactorial 
    {
        private Calculator _calculator;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsFactorial(Calculator calc)
        {
            this._calculator =  calc;
            this._result = 0;
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0)
        {
            try
            {
                _result = _calculator.Factorial(p0);
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


    [Binding]
    [Scope(Tag = "Availability")]
    public sealed class UsingCalculatorStepDefinitionsAvailablity
    {
        
        private Calculator _calculator;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsAvailablity(Calculator calc)
        {
            this._calculator =  calc;
            this._result = 0;
            this._error = "";
        }
        
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.MTBF(p0, p1);
        }

        
        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculator2(double p0, double p1)
        {
            try{
                _result = _calculator.Availability(p0, p1);
            }catch(ArgumentException ex){
                _error = ex.Message;
            }
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
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

    [Binding]
    [Scope(Tag = "FailureIntensity")]
    public sealed class UsingCalculatorStepDefinitionsFailureIntensity
    {
        
        private Calculator _calculator;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsFailureIntensity(Calculator calc)
        {
            this._calculator =  calc;
            this._result = 0;
            this._error = "";
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }

        [When(@"I have entered (.*), (.*), (.*) into the calculator and press Failure Intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1, double p2)
        {
            try{
                _result = _calculator.FailureIntensity(p0, p1, p2);
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
    [Scope(Tag = "AverageNumberOfFailures")]
    public sealed class UsingCalculatorStepDefinitionsAverageNumberOfFailures
    {
        
        private Calculator _calculator;
        private double _result;
        private string _error;
        public UsingCalculatorStepDefinitionsAverageNumberOfFailures(Calculator calc)
        {
            this._calculator =  calc;
            this._result = 0;
            this._error = "";
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }

        [When(@"I have entered (.*), (.*), (.*) into the calculator and press Average number of expected failures")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1, double p2)
        {
            try{
                _result = _calculator.AverageNumberOfFailures(p0, p1, p2);
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