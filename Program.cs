using DockerCalculator;

class Program
{
    static void Main()
    {
        using var dbContext = new CalculatorDbContext();
        var calculator = new Calculator(dbContext);

        // Example usage
        var result = calculator.Add(5, 3);
        Console.WriteLine($"Result: {result}");

        var result2 = calculator.Multiply(5, 3);
        Console.WriteLine($"Result: {result2}");
    }
}