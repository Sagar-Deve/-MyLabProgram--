// Exercise 3 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Addition Calculator");
        //Ask the user to enter the first number
        Console.Write("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        //Ask the user to enter the second number
        Console.Write("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = a + b;

        Console.WriteLine("The total is: " + result);

        Console.Read();


    }

}
