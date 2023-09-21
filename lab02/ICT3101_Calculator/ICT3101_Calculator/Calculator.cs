public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        if(IsBinary(num1) && IsBinary(num2))
        {
            string result = num1.ToString() + num2.ToString();

            int binary = Convert.ToInt32(result, 2);

            return Convert.ToDouble(binary);
        }

        return (num1 + num2);
    }
    private bool IsBinary(double num)
    {
        string numString = num.ToString();
        foreach(char c in numString)
        {
            if(c != '0' && c != '1')
            {
                return false;
            }
        }
        return true;
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }
    public double Divide(double num1, double num2)
    {   
        if(num1 == 0 && num2 == 0){
            return 1;
        }

        if(num1 == 0){
            return 0;
        }

        if(num2 == 0){
            throw new ArgumentException("positive_infinity");
        }

        return num1 / num2;
    }

    public double Factorial(double num1)
    {   
        //if num1 is negative, throw exception
        if(num1 < 0)
        {
            throw new ArgumentException("Cannot factorial negative number");
        }

        if(num1 % 1 != 0)
        {
            throw new ArgumentException("Cannot factorial decimal number");
        }

        //if num1 is 0, return 1
        if(num1 == 0)
        {
            return 1;
        }
        
        return Multiply(num1, Factorial(Subtract(num1, 1)));
    }

    public double AreaOfTriangle(double num1, double num2)
    {
        if(num1 <= 0 || num2 <= 0)
        {
            throw new ArgumentException("Cannot have negative or zero side length");
        }

        return Divide(Multiply(num1, num2), 2);
    }

    public double AreaOfCircle(double num1)
    {
        if(num1 <= 0)
        {
            throw new ArgumentException("Cannot have negative or zero radius");
        }

        return Multiply(Multiply(num1, num1), Math.PI);
    }

    public double UnknownFunctionA(double num1, double num2)
    {
        if(num1 < num2){
            throw new ArgumentException("Cannot have num1 greater than num2");
        }

        //Permutation
        
        return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
    }

    public double UnknownFunctionB(double num1, double num2)
    {
        if(num1 < num2){
            throw new ArgumentException("Cannot have num1 greater than num2");
        }

        //Binomial Coefficient

        return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));
    }

    public double MTBF(double MTTF, double MTTR){
        if(MTTF <= 0 && MTTR <= 0){
            throw new ArgumentException("MTTF and MTTR Cannot be less than or equal to 0");
        }

        if(MTTF <= 0){
            throw new ArgumentException("MTTF Cannot be less than or equal to 0");
        }

        if(MTTR <= 0){
            throw new ArgumentException("MTTR Cannot be less than or equal to 0");
        }

        return Add(MTTF, MTTR);
    }

    public double Availability(double MTTR, double MTBF){
        if(MTBF <= 0 && MTTR <= 0){
            throw new ArgumentException("MTTR and MTBF Cannot be less than or equal to 0");
        }
        
        if(MTBF <= 0){
            throw new ArgumentException("MTBF Cannot be less than or equal to 0");
        }
        if(MTTR <= 0){
            throw new ArgumentException("MTTR Cannot be less than or equal to 0");
        }
        
        if(MTTR >= MTBF){
            throw new ArgumentException("MTTR cannot be greater than or equal to MTBF");
        }
    
        return Divide(MTTR, MTBF);
    }

    public double FailureIntensity(double initial_failure_intensity, double number_of_failures_at_time_t, double failures_over_infinite_time){

        if(initial_failure_intensity <= 0 && number_of_failures_at_time_t <= 0 && failures_over_infinite_time <= 0){
            throw new ArgumentException("Initial failure intensity, number of failures at time t and failures over infinite time cannot be less than or equal to 0");
        }

        if(initial_failure_intensity <= 0){
            throw new ArgumentException("Initial failure intensity cant be less than or equal 0");
        }

        if(number_of_failures_at_time_t <= 0){
            throw new ArgumentException("Number of failures at time t cant be less than or equal 0");
        }

        if(failures_over_infinite_time <= 0){
            throw new ArgumentException("Failures over infinite time cant be less than or equal 0");
        }

        return Multiply(initial_failure_intensity, Subtract(1,Divide(number_of_failures_at_time_t, failures_over_infinite_time)));
    }

    public double AverageNumberOfFailures(double failures_over_infinite_time, double initial_failure_intensity, double time_t){
        if(failures_over_infinite_time <= 0 && initial_failure_intensity <= 0 && time_t <= 0){
            throw new ArgumentException("Failures over infinite time, initial failure intensity and time t cannot be less than or equal to 0");
        }

        if(failures_over_infinite_time <= 0){
            throw new ArgumentException("Failures over infinite time cant be less than or equal 0");
        }

        if(initial_failure_intensity <= 0){
            throw new ArgumentException("Initial failure intensity cant be less than or equal 0");
        }

        if(time_t <= 0){
            throw new ArgumentException("Time t cant be less than or equal 0");
        }

        
        return Math.Round(Multiply(failures_over_infinite_time, Subtract(1, Math.Pow(Math.E, Multiply(Multiply(-1, Divide(initial_failure_intensity, failures_over_infinite_time)), time_t)))));
    }

    public double DefectDensity(double number_of_defects, double kloc){
        if(number_of_defects <= 0 && kloc <= 0){
            throw new ArgumentException("Number of defects and KLOC cannot be less than or equal to 0");
        }

        if(number_of_defects <= 0){
            throw new ArgumentException("Number of defects cant be less than or equal 0");
        }

        if(kloc <= 0){
            throw new ArgumentException("KLOC cant be less than or equal 0");
        }

        return Divide(number_of_defects, kloc);
    }

    public double NewSSI(double previous_release_KLOC, double new_release_KLOC, double percent_changed_lines, double deleted_code){
        if(previous_release_KLOC < 0 && new_release_KLOC < 0 && percent_changed_lines < 0 && deleted_code < 0){
            throw new ArgumentException("Previous release KLOC, New release KLOC, Percent of Changed Lines, Deleted Code cant be less than 0");
        }

        if(previous_release_KLOC < 0){
            throw new ArgumentException("Previous release KLOC cant be less than 0");
        }

        if(new_release_KLOC < 0){
            throw new ArgumentException("New release KLOC cant be less than 0");
        }

        if(percent_changed_lines < 0){
            throw new ArgumentException("Percent of Changed Lines cant be less than 0");
        }

        if(percent_changed_lines > 100){
            throw new ArgumentException("Percent of Changed Lines cant be more than 100%");
        }

        if(deleted_code <= 0){
            throw new ArgumentException("Deleted Code cant be less than 0");
        }

        return Add(previous_release_KLOC, Subtract(new_release_KLOC, Add(Multiply(new_release_KLOC, Divide(percent_changed_lines, 100)), deleted_code)));
    }

    public double LogarithmicFailureIntensity(double initial_failure_intensity, double number_of_failures_at_time_t, double decay_parameter){
        if(decay_parameter <= 0 && initial_failure_intensity <= 0 && number_of_failures_at_time_t <= 0){
            throw new ArgumentException("Initial failure intensity, number of failures at time t and decay parameter cannot be less than or equal to 0");
        }

        if(decay_parameter <= 0){
            throw new ArgumentException("Decay Parameter cant be less than or equal 0");
        }

        if(initial_failure_intensity <= 0){
            throw new ArgumentException("Initial failure intensity cant be less than or equal 0");
        }

        if(number_of_failures_at_time_t <= 0){
            throw new ArgumentException("Number of failures at time t cant be less than or equal 0");
        }

        return Math.Round(Multiply(initial_failure_intensity, Math.Pow(Math.E, Multiply(Multiply(-1, decay_parameter), number_of_failures_at_time_t))),2);
    }

    public double LogarithmicAverageNumberOfFailures(double decay_parameter, double initial_failure_intensity, double time_t){
        if(decay_parameter <= 0 && initial_failure_intensity <= 0 && time_t <= 0){
            throw new ArgumentException("Decay Parameter, initial failure intensity and time t cannot be less than or equal to 0");
        }

        if(decay_parameter <= 0){
            throw new ArgumentException("Decay Parameter cant be less than or equal 0");
        }

        if(initial_failure_intensity <= 0){
            throw new ArgumentException("Initial failure intensity cant be less than or equal 0");
        }

        if(time_t <= 0){
            throw new ArgumentException("Time t cant be less than or equal 0");
        }

        return Math.Round(Multiply(Divide(1, decay_parameter), Math.Log(Add(1, Multiply(initial_failure_intensity, Multiply(decay_parameter, time_t))))));
    }
}