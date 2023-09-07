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
        return (num1 + num2);
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
        if(num1  == 0 || num2 == 0)
        {
            throw new ArgumentException("Cannot divide by zero");
        }

        return (num1 / num2);
    }

    public double Factorial(double num1)
    {   
        //if num1 is negative, throw exception
        if(num1 < 0)
        {
            throw new ArgumentException("Cannot factorial negative number");
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
}