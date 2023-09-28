using TechTalk.SpecFlow;
using NUnit.Framework;

[Binding]
public class CalculatorContext{
    public Calculator _calculator;

    
    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        this._calculator = new Calculator();
    }
}