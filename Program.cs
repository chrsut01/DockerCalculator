using DockerCalculator;

class Program
{
    static void Main()
    {
        using var dbContext = new CalculatorDbContext();
        var calculator = new Calculator(dbContext);

        // Example usage
        var result = calculator.Add(12, 3);
        Console.WriteLine($"Add Result: {result}");

        var result2 = calculator.Multiply(12, 3);
        Console.WriteLine($"Multiply Result: {result2}");
    }
}