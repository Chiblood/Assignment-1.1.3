// 3. Write a C# program to print the result of dividing two numbers. Print the quotient and the remainder as well. Get the input from the user.
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the dividend (numerator):");
        int dividend = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the divisor (denominator):");
        int divisor = int.Parse(Console.ReadLine());
        if (divisor == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");
    }
}