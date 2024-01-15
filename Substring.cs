using System;
class SubstringList
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();
        Console.WriteLine("\nAll Substrings:");
        ListAllSubstrings(inputString);
    }
    static void ListAllSubstrings(string input)
    {

        for (int start = 0; start < input.Length; start++)
        {
            for (int length = 1; length <= input.Length - start; length++)
            {
                string substring = input.Substring(start, length);
                Console.WriteLine(substring);
            }
        }
    }
}