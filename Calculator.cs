using System;
class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Arithmetic Calculator");
        Console.WriteLine("---------------------------");
        // Read operator
        Console.Write("Enter operator (+, -, *, /, %): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();
        // Read operands
        Console.Write("Enter first operand: ");
        double operand1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second operand: ");
        double operand2 = Convert.ToDouble(Console.ReadLine());
        // Perform the operation
        double result = 0;
        switch (operation)
        {
            case '+':
                result = operand1 + operand2;
                break;
            case '-':
                result = operand1 - operand2;
                break;
            case '*':
                result = operand1 * operand2;
                break;
            case '/':
                if (operand2 != 0)
                {
                    result = operand1 / operand2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            case '%':
                if (operand2 != 0)
                {
                    result = operand1 % operand2;
                }
                else
                {
                    Console.WriteLine("Error: Modulus by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator");
                return;
        }
        // Display the result

        Console.WriteLine($"Result: {operand1} {operation} {operand2} = {result}");
    }
}