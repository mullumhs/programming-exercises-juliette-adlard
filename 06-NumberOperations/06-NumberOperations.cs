using System;

/*
===============================================================================
PROJECT 06: NUMBER OPERATIONS
===============================================================================
Objective:
- Practice obtaining numerical input from the user and performing basic arithmetic operations.

Main Tasks:
1. Store user input as a floating point number for the variable 'y' as shown for 'x'.
2. Perform and output the result of multiplication using '*' with 'x' and 'y'.
3. Perform and output the result of subtraction using '-' with 'x' and 'y'.
4. Perform and output the result of division using '/' with 'x' and 'y'.
5. Wait for input before ending the program.

Questions:
1. What does "Convert.ToDouble" do?
Converts an eligible variable into a double.
2. What is a parameter? Give an example of where you have used one.
A variable inside a method. I used a parameter in line 56.
3. Why is the 'Console.ReadLine()' a parameter to Convert.ToDouble()?
Because it is used inside the convertion to a double.

Extension Tasks:
1. Modify the program to work with the 'double' type.
2. Research how to get the remainder of a division using the 'modulus operator'.

Example:
- Below is what the final program output might look like:

    Please enter a number for X:
    7
    Please enter a number for Y:
    3
    X plus Y = 10
    X times Y = 21
    X minus Y = 4
    X divided by Y = 2.333333

Additional Resources:
- Convert.ToDouble: https://www.tutorialspoint.com/convert-tosingle-method-in-chash
- Parameters: https://www.w3schools.com/cs/cs_method_parameters.php
- Arithmetic Operators: https://www.w3schools.com/cs/cs_operators_arithmetic.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_06_NumberOperations
    {
        static void Main(string[] args)
        {
            // How to input a number from the user and store it in a variable 'x'
            Console.WriteLine("Please enter a number for X:");
            double x = Convert.ToDouble(Console.ReadLine());

            // Your code goes below here
            Console.WriteLine("Please enter a number for Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            // Operations
            Console.WriteLine($"The sum of {x} and {y} is {x + y}");

            Console.WriteLine($"The difference between {x} and {y} is {x - y}");

            Console.WriteLine($"The product of {x} and {y} is {x * y}");

            Console.WriteLine($"The quotient of {x} and {y} is {x / y}");

            Console.WriteLine($"{x} divided by {y} is {Math.Floor(x / y)} remainder {x%y}");

            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/
