public interface ICalculator
{
    /// <summary>
    /// A methos that returns the sum of A + B
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>a + b</returns>
    public double Add(double a, double b);
    /// <summary>
    /// A method that returns the sum og A - B
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>a - b</returns>
    public double Subtract(double a, double b);

    /// <summary>
    /// A methos that returns the sum of A * B
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>a * b</returns>
    public double Multiply(double a, double b);

    /// <summary>
    /// A method that returns the sum of A / B, B cannot be 0 or NULL
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>a / b</returns>
    public double Divide(double a, double b);
}