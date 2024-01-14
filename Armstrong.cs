using System;
class ArmstrongNumbers
{
    static void Main()
    {
        Console.WriteLine("Armstrong Numbers between 1 and 1000:");
        for (int number = 1; number <= 1000; number++)
        {
            if (IsArmstrongNumber(number))
            {
                Console.WriteLine(number);
            }
        }
    }
    static bool IsArmstrongNumber(int num)
    {
        int originalNumber = num;
        int numDigits = (int)Math.Floor(Math.Log10(num) + 1);
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, numDigits);
            num /= 10;
        }
        return sum == originalNumber;
    }
}