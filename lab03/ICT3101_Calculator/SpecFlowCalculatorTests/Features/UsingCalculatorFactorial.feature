Feature: UsingCalculatorFactorial
    Factorial BIM BIM BAM BAM CYKA BLYAT
    @Factorial
    Scenario: Calculating Factorial
        Given I have a calculator
        When I have entered 5 into the calculator and press factorial
        Then the factorial result should be 120
    @Factorial
    Scenario: Calculating Factorial When Number Is Zero
        Given I have a calculator
        When I have entered 0 into the calculator and press factorial
        Then the factorial result should be 1
    @Factorial
    Scenario: Calculating Factorial When Number Is Negative
        Given I have a calculator
        When I have entered -5 into the calculator and press factorial
        Then the factorial result should be "Cannot factorial negative number"
    @Factorial
    Scenario: Calculating Factorial When Number Is Decimal
        Given I have a calculator
        When I have entered 5.5 into the calculator and press factorial
        Then the factorial result should be "Cannot factorial decimal number"
    