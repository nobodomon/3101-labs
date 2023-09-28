Feature: UsingCalculatorLogarithmicReliability
    In order to calculate the Logarithmic Musa model's failures/intensities
    As a Software Quality Metric enthusiast
    I want to use my calculator to do this

    @LogarithmicFailureIntensity
    Scenario: Calculate the Logarithmic Musa model's failures/intensities
        Given I have a calculator
        When I have entered <initial_failure_intensity>, <number_of_failures_at_time_t>, <decay_parameter> into the calculator and press Logarithmic Failure Intensity
        Then the Failure Intensity result should be <failure_intensity>
        Examples:
            | initial_failure_intensity | number_of_failures_at_time_t | decay_parameter | failure_intensity                                                                                                           |
            | 10                        | 50                           | 0.02                         | 3.68                                                                                                                           |
            | 0                         | 10                           | 1000                        | "Initial failure intensity cant be less than or equal 0"                                                                    |
            | 100                       | 0                            | 1000                        | "Number of failures at time t cant be less than or equal 0"                                                                 |
            | 100                       | 10                           | 0                           | "Decay Parameter cant be less than or equal 0"                                                                  |
            | 0                         | 0                            | 0                           | "Initial failure intensity, number of failures at time t and decay parameter cannot be less than or equal to 0" |


    @LogarithmicAverageNumberOfFailures
    Scenario: Calculate the Logarithmic Average number of expected failures
        Given I have a calculator
        When I have entered <decay_parameter>, <initial_failure_intensity>, <time_t> into the calculator and press Logarithmic Average number of expected failures
        Then the average number of expected failures result should be <average_number_of_failures>
        Examples:
            | decay_parameter | initial_failure_intensity | time_t | average_number_of_failures                                                                            |
            | 0.02             | 10                        | 10     | 55                                                                                                    |
            | 0.02             | 10                        | 100    | 152                                                                                                   |
            | 0               | 10                        | 1000   | "Decay Parameter cant be less than or equal 0"                                            |
            | 100             | 0                         | 1000   | "Initial failure intensity cant be less than or equal 0"                                              |
            | 100             | 10                        | 0      | "Time t cant be less than or equal 0"                                                                 |
            | 0               | 0                         | 0      | "Decay Parameter, initial failure intensity and time t cannot be less than or equal to 0" |