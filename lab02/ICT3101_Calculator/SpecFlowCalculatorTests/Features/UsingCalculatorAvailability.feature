Feature: UsingCalculatorAvailability
    In order to calculate MTBF and Availability
    As someone who struggles with math
    I want to be able to use my calculator to do this
    @Availability
    Scenario: Calculating MTBF
        Given I have a calculator
        When I have entered <MTTF> and <MTTR> into the calculator and press MTBF
        Then the availability result should be <MTBFResult>
        Examples:
            | MTTF | MTTR | MTBFResult |
            | 100  | 200  | 300        |
            | 300  | 300  | 600        |
    @Availability
    Scenario: Calculating Availability
        Given I have a calculator
        When I have entered <MTTR> and <MTBF> into the calculator and press Availability
        Then the availability result should be <AvailabilityResult>
        Examples:
            | MTTR | MTBF | AvailabilityResult                                |
            | 100  | 200  | 0.5                                      |
            | 100  | 100  | "MTTR cannot be greater than or equal to MTBF"                    |
            | 100  | 0    | "MTBF Cannot be less than or equal to 0"          |
            | 0    | 100  | "MTTR Cannot be less than or equal to 0"          |
            | 0    | 0    | "MTTR and MTBF Cannot be less than or equal to 0" |

