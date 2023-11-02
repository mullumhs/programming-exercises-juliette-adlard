using System;

/*
===============================================================================
PROJECT 12: BETTER AREA CALCULATOR
===============================================================================
Objective:
- Learn how to refactor code into more manageable chunks using methods, improving readability and reusability of the code.

Main Tasks:
1. Copy and paste your program from the previous lesson into this one.
2. Write methods for each of the main functions of the program. E.g. ShowMenu, CalculateRectangle, CalculateTriangle, etc.
3. Move the corresponding code into each method.
4. Call the methods from the Main method.

Questions:
1. What is the purpose of splitting the code into smaller chunks (methods)?
2. Why is it important to give a warning message to the user in the else statement?

Extension Tasks:
1. Add a trapezium option to the program. It should also be a separate method.

Example:
- Below is an example of the program's output:

    Choose an Option:
    1. Area of Circle
    2. Area of Rectangle
    3. Area of Triangle

    2

    Enter Width: 3
    Enter Height: 4

    The area of the rectangle is 12

    "Press any key to exit...

Additional Resources:
- Methods: https://www.w3schools.com/cs/cs_methods.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_12_BetterAreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code goes below here

            ShowMenu();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CalculateCircle();
            }

            else if (choice == "2")
            {
                CalculateRectangle();
            }

            else if (choice == "3")
            {
                CalculateTriangle();
            }

            else if (choice == "4")
            {
                CalculateTrapezium();
            }

            else
            {
                Invalid();
            }

            Exit();
        }

        static void ShowMenu()
        {
            Console.WriteLine("Choose an option:\n1. Area of circle\n2. Area of rectangle\n3. Area of right-angled triangle\n4. Area of trapezium\n");
        }

        static void CalculateCircle()
        {
            Console.Write("\nEnter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nThe area of the circle is {Math.PI * Math.Pow(radius, 2)}");
        }

        static void CalculateRectangle()
        {
            Console.Write("\nEnter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nThe area of the rectangle is {width * height}");
        }

        static void CalculateTriangle()
        {
            Console.Write("\nEnter base length: ");
            double baselength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter perpendicular height: ");
            double perpheight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"g\nThe area of the triangle is {baselength * perpheight * 0.5}");
        }

        static void CalculateTrapezium()
        {
            Console.Write("\nEnter top width: ");
            double width1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter bottom width: ");
            double width2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter perpendicular height: ");
            double perpheighttrap = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nThe area of the trapezium is {((width1 + width2) / 2) * perpheighttrap}");
        }

        static void Invalid()
        {
            Console.WriteLine("\nInvalid answer");
        }

        static void Exit()
        {
            Console.WriteLine("\nPress any key to exit...");
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