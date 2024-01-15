using System;
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Division by Zero Exception:");
        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator / denominator;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
        Console.WriteLine("\nIndex Out of Range Exception:");
        try
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = 10; 
            int value = numbers[index]; 
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}