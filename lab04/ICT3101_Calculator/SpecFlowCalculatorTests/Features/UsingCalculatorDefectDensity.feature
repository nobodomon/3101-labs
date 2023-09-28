Feature: UsingCalculatorDefectDensity
    In order to calculate the Logarithmic Musa model's failures/intensities
    As a Software Quality Metric enthusiast
    I want to use my calculator to do this

    @DefectDensity
    Scenario: Calculate the Defect Density of a system
        Given I have a calculator
        When I have entered <number_of_defects>, <KLOC> into the calculator and press Defect Density
        Then the defect density result should be <defect_density>
        Examples:
            | number_of_defects | KLOC | defect_density                                                 |
            | 100               | 10   | 10                                                             |
            | 0                 | 10   | "Number of defects cant be less than or equal 0"                |
            | 100               | 0    | "KLOC cant be less than or equal 0"                            |
            | 0                 | 0    | "Number of defects and KLOC cannot be less than or equal to 0" |


    @NewSSI
    Scenario: Calculate the new SSI
        Given I have a calculator
        When I have entered <previous_release_KLOC>, <new_release_KLOC>, <percent_changed_lines>, <deleted_code> into the calculator and press New SSI
        Then the new SSI result should be <new_SSI>
        Examples:
            | previous_release_KLOC | new_release_KLOC | percent_changed_lines | deleted_code | new_SSI                                                                                               |
            | 100                   | 20               | 10                    | 10           | 108                                                                                               |
            | 0                     | 10               | 10                    | -1           | "Deleted Code cant be less than 0"                                                                    |
            | 100                   | 0                | -1                    | 10           | "Percent of Changed Lines cant be less than 0"                                                        |
            | 100                   | -1               | 0                     | 10           | "New release KLOC cant be less than 0"                                                                |
            | -1                    | 10               | 10                    | 0            | "Previous release KLOC cant be less than 0"                                                           |
            | -1                    | -1               | -1                    | -1           | "Previous release KLOC, New release KLOC, Percent of Changed Lines, Deleted Code cant be less than 0" |
            | 0                     | 0                | 120                   | 0            | "Percent of Changed Lines cant be more than 100%"                                                          |