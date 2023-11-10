using System;

/*
===============================================================================
PROJECT 14: PARAMETERS
===============================================================================
Objective:
- Understand and practice using parameters in methods.

Main Tasks:
1. Create a method called "SayHello" to print the message "Hello (name)".
2. Create a method called "SubtractNumbers" that takes two integers, subtracts one and prints the result.
3. Create a method called "Exit" that prints the message "Press any key to exit...", then waits for user input.

Example:
- Below is an example of a method with parameters:

    private static void AddNumbers(int num1, int num2)
    {
        int answer = num1 + num2;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"{num1} + {num2} equals {answer}");
    }

Questions:
1. What is a parameter?
a piece of information used in the method
2. When writing a method, what two things do you need to supply to create a parameter for it? 
   E.g. static void MyMethod(firstThing secondThing)
The type of data it is (string, int, bool etc.) and what you're going to call it, essentially creating a variable
3. What is the difference between a parameter and an argument?
the argument is used when the method is called, the parameter is used when the method is made

Extension Tasks:
1. Update "SayHello" to take two parameters, one for the first name and one for the last name.
2. Update the "Exit" method to take a ConsoleColor as a parameter, then use it to change the colour of the text.
3. Write your own methods that takes one or more parameters of various data types.

Additional Resources:
- Parameters in C#: https://www.tutorialspoint.com/csharp/csharp_value_parameters.htm
- Passing Parameters: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/passing-parameters
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_14_Parameters
    {
        static void Main(string[] args)
        {
            // Call the methods here, passing in the required arguments

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            ProductCalc(num1, num2);
            Exit(name, surname);
        }

        // Write your methods including parameters here

        static void ProductCalc(double num1, double num2)
        {
            double answer = num1 * num2;
            Console.WriteLine($"The product of your numbers is {answer}.");
        }

        static void Exit(string name, string surname)
        {
            Console.WriteLine($"{name} {surname}, you must now press a key to exit.");
            Console.ReadKey();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/