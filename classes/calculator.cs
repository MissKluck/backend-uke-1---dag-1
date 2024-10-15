public class Calculator  : ICalculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public decimal Subtract(double a, double b)
    {
        if (b == 0 //)
        {}
        return
    }

    /// <summary>
    /// A method that returns the power of x^n
    /// </summary>
    /// <param name="a">value a</param>
    /// <param name="n">value n</param>
    /// <returns>the power of n to x</returns>
    public double Power(double x, double n)
    {
        return Math.Pow(x, n);
    }

}