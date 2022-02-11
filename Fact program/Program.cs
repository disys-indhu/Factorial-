using System;
class Factorial
{
    public static void Main(string[] args)
    {
        int value, fact = 1, number;
        Console.Write("Enter any Number: ");
        number = int.Parse(Console.ReadLine());
        for (value = 1; value <= number; value++)
        {
            fact = fact * value;
        }
        Console.Write("Factorial of " + number + " is: " + fact);
    }
}
