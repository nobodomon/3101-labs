Feature: UsingCalculatorBasicReliability
    In order to calculate the Basic Musa model's failures/intensities
    As a Software Quality Metric enthusiast
    I want to use my calculator to do this

    @FailureIntensity
    Scenario: Calculate the Basic Musa model's failures/intensities
        Given I have a calculator
        When I have entered <initial_failure_intensity>, <number_of_failures_at_time_t>, <failures_over_infinite_time> into the calculator and press Failure Intensity
        Then the Failure Intensity result should be <failure_intensity>
        Examples:
            | initial_failure_intensity | number_of_failures_at_time_t | failures_over_infinite_time | failure_intensity                                                                                                           |
            | 10                        | 50                           | 100                         | 5                                                                                                                           |
            | 0                         | 10                           | 1000                        | "Initial failure intensity cant be less than or equal 0"                                                                    |
            | 100                       | 0                            | 1000                        | "Number of failures at time t cant be less than or equal 0"                                                                 |
            | 100                       | 10                           | 0                           | "Failures over infinite time cant be less than or equal 0"                                                                  |
            | 0                         | 0                            | 0                           | "Initial failure intensity, number of failures at time t and failures over infinite time cannot be less than or equal to 0" |


    @AverageNumberOfFailures
    Scenario: Calculate the Average number of expected failures
        Given I have a calculator
        When I have entered <failures_over_infinite_time>, <initial_failure_intensity>, <time_t> into the calculator and press Average number of expected failures
        Then the average number of expected failures result should be <average_number_of_failures>
        Examples:
            | failures_over_infinite_time | initial_failure_intensity | time_t | average_number_of_failures                                                                            |
            | 100                         | 10                        | 10     | 63                                                                                                    |
            | 100                         | 10                        | 100    | 100                                                                                                   |
            | 0                           | 10                        | 1000   | "Failures over infinite time cant be less than or equal 0"                                            |
            | 100                         | 0                         | 1000   | "Initial failure intensity cant be less than or equal 0"                                              |
            | 100                         | 10                        | 0      | "Time t cant be less than or equal 0"                                                                 |
            | 0                           | 0                         | 0      | "Failures over infinite time, initial failure intensity and time t cannot be less than or equal to 0" |