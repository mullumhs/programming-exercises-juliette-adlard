using System;

/*
===============================================================================
PROJECT 13: METHODS
===============================================================================
Objective:
- Understand and practice creating and calling methods in C#.

Main Tasks:
1. Create a method called "SayHello" to print the message "Hello World".
2. Create a method called "Exit" to print the message "Press any key to exit..." and wait for user input.

Questions:
1. What is a method?
A set of instructions with a name that can be easily executed by calling the name.
2. What does the 'void' keyword mean?
Void identifies a method that will not return a value
3. What does it mean to 'call' a method?
To call a method means to tell the computer to follow the instructions of that method

Extension Tasks:
1. Try creating extra methods that do whatever you like.
2. Try calling the methods multiple times.
3. Try calling methods from within another method.

Additional Resources:
- Methods: https://www.tutorialspoint.com/csharp/csharp_methods.htm
- Methods: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_13_Methods
    {
        static void Main(string[] args)
        {
            // Call the methods here

            SayHello();
            Continue();
            SaySomething();
            Continue();
            Hurt();
            Exit();
        }

        // Write your methods here
        static void SayHello()
        {
            Console.WriteLine("Hello World");
        }
        
        static void SaySomething()
        {
            Console.WriteLine("\nSay something cohesive.");
        }

        static void Hurt()
        {
            Console.WriteLine("\nWhy don't you want to talk to me? :c");
        }

        static void Continue()
        {
            Console.WriteLine("\n(Answer me pls)");
            Console.ReadKey();
        }

        static void Exit()
        {
            Console.WriteLine("\n(ANSWER MEEE)");
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