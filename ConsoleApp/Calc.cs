namespace ConsoleApp;

public class Calc
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int subtract(int a, int b)
    {
        return a - b;
    }

    public int multiply(int a, int b)
    {
        return a * b;
    }

    public int divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return a / b;
    }
    public int modulus(int a, int b)
    {
        return a % b;
    }

    public int power(int a, int b)
    {
        return (int)Math.Pow(a, b);
    }
}