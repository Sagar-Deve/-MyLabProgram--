// Exercise 3 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Addition Calculator");

        // Ask the user to enter the first number with input validation
        int a;
        while (true)
        {
            Console.Write("Enter the first number: ");
            if (int.TryParse(Console.ReadLine(), out a))
                break;
            else
                Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        // Ask the user to enter the second number with input validation
        int b;
        while (true)
        {
            Console.Write("Enter the second number: ");
            if (int.TryParse(Console.ReadLine(), out b))
                break;
            else
                Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        int result = a + b;
        Console.WriteLine("The total is: " + result);

        // Confirm calculation completion and wait for user input before closing
        Console.WriteLine("Calculation complete. Press any key to exit.");
        Console.ReadKey();
    }
}
