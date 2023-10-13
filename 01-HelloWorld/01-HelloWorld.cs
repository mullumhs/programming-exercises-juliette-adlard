using System;

/*
===============================================================================
PROJECT 01: HELLO WORLD
===============================================================================
Objective:
- Familiarize with basic console output and input operations in C#.

Main Tasks:
1. Output 'Hello World!' to the console screen using 'Console.WriteLine();'.
2. Make the program wait for input using 'Console.ReadLine();'.

Questions:
1. What is the difference between input and output?
input receives information
output provides information

Extension Tasks:
1. Output another message / pause after the ReadLine.
2. Research online how to change the colour and/or make the console beep.

Additional Resources:
- Microsoft Docs: Console.WriteLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline
- Microsoft Docs: Console.ReadLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.readline
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_01_HelloWorld
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("Hello World");
            Console.ReadLine();
            Console.WriteLine("Hello World?");
            Console.Beep(369, 200);
            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Code:

Good job on completing the main tasks correctly. The 'Console.WriteLine();' and 'Console.ReadLine();' functions are used correctly to output a message and wait for user input.

For the extension tasks, you successfully added another message after the 'Console.ReadLine();', and used the 'Console.Beep();' function to make the console beep.

However, in the first 'Console.WriteLine();', the output message should be 'Hello World!' instead of 'Hello World'.

Code Commenting:

Your code is well-commented at the top, explaining the project's objective and tasks.

It would be beneficial to add some comments in the code itself, especially for the extension tasks. For example, you could add a comment explaining what the parameters in 'Console.Beep(369, 200);' are doing.

Answers to Questions:

Your answer to the question about the difference between input and output is correct but could be more detailed. For example, you could mention that input is data or information that a user provides to the computer, while output is data or information that the computer provides to the user.
Extension Tasks:

You did a great job completing the extension tasks.

For the second extension task, you could also add a comment or a piece of code showing how to change the console color. The 'Console.ForegroundColor' or 'Console.BackgroundColor' properties could be used for this.

Keep up the good work!
===============================================================================
*/