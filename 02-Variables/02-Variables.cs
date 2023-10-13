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
            if (colour != "piss-yellow")
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



===============================================================================
*/
