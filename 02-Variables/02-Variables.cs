using System;
using System.Xml.Linq;

/*
===============================================================================
PROJECT 02: VARIABLES
===============================================================================
Objective:
- Understand and practice declaring variables and manipulating string data.

Main Tasks:
1. Create a string variable and assign it a value.
2. Output a message that contains this variable.
3. Make the program wait for input.

Questions:
1. What is a variable?
a saved piece of data
2. What is a string?
a piece of text

Extension Tasks:
1. Try creating two string variables and using them in the same message.
2. Use Google to work out how to change a variable to uppercase or lowercase before outputting it.

Additional Resources:
- Variables: https://www.tutorialspoint.com/csharp/csharp_variables.htm
- Data Types: https://www.tutorialspoint.com/csharp/csharp_data_types.htm
- String Manipulation: https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_02_Variables
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("What is your favourite colour?");
            string colour = Console.ReadLine();
            colour = colour.ToLower();
            if (colour == "orange")
                Console.WriteLine("Ew, that's an ugly colour.");
            else Console.WriteLine("You have great taste!");
            Console.ReadLine();
            
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Code:

Good job on completing the main tasks. You've created string variables, assigned them values based on user input, and used them in output messages.

In the extension tasks, you've successfully created two string variables and used them in the same message. You've also changed a variable to lowercase before outputting it.

However, be careful with your user messages. The message "Ew, that's an ugly colour." might come across as rude to some users. It's generally a good idea to keep user messages neutral and professional.

Code Commenting:

Your code is well-commented at the top, explaining the project's objective and tasks.

It would be beneficial to add some comments in the code itself, especially for the extension tasks. For example, you could add a comment explaining what the colour.ToLower(); line is doing.

Answers to Questions:

Your answers to the questions are correct but could be more detailed. For example, you could explain that a variable is a named space in the computer's memory where a program can store data and retrieve it later, and a string is a sequence of characters.
Extension Tasks:

You did a great job completing the extension tasks.

For the second extension task, you could also add a comment or a piece of code showing how to change a variable to uppercase. The string.ToUpper(); method could be used for this.

Keep up the good work!
===============================================================================
*/
