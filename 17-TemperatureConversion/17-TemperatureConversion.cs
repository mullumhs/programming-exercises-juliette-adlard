using System;

/*
===============================================================================
PROJECT 17: TEMPERATURE CONVERSION
===============================================================================
Objective:
- Utilise functions to create a program that converts temperatures between Celsius and Fahrenheit based on user input.

Example Output:
- This is how your program should behave:

    What would you like to do?
    1. Celsius to Fahrenheit
    2. Fahrenheit to Celsius
    1
    Enter temperature in Celsius: 0
    That is 32 Fahrenheit

Pseudocode:
    BEGIN Main
        choice = MainMenu()
        IF choice = 1 THEN
            result = CelsiusToFahrenheit()
            PRINT result
        ELSE IF choice = 2 THEN
            result = FahrenheitToCelsius()
            PRINT result
        ELSE
            PRINT "Invalid Choice!"
        END IF
    END Main

    BEGIN CelsiusToFahrenheit
        c = GetTemperature("Celsius")
        f = (c * 9/5) + 32
        RETURN f
    END CelsiusToFahrenheit 

    BEGIN FahrenheitToCelsius
        f = GetTemperature("Fahrenheit")
        c = (f - 32) * 5/9
        RETURN c
    END FahrenheitToCelsius

    BEGIN GetTemperature(unit)
        PRINT "Enter temperature in " + unit
        INPUT temp
        RETURN temp
    END GetTemperature

Main Tasks:
1. Write a function to convert Celsius to Fahrenheit.
2. Write a function to convert Fahrenheit to Celsius.
3. Implement a menu for the user to choose which conversion they want to perform.
4. Display the result of the conversion based on the user's choice.

Questions:
1. What did you find challenging about implementing an entire program yourself?

Extension Tasks:
1. Add an option in the menu for the user to exit the program.
2. Enhance the program to handle invalid input gracefully without crashing.
3. Research and implement a function to convert temperature to and from Kelvin.
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_17_TemperatureConversion
    {
        static void Main(string[] args)
        {
            // Write your code here

            string choice = ChooseConversion();

            if (choice == "1")
            {
                string unit = "celcius";
                double temp = GetTemp(unit);
                CelciusToFahrenheit(temp);
            }
            else if (choice == "2")
            {
                string unit = "fahrenheit";
                double temp = GetTemp(unit);
                FahrenheitToCelcius(temp);
            }
            else
            {
                Console.WriteLine("INVALID RESPONSE");
            }

            Exit();

        }

        static string ChooseConversion()
        {
            Console.WriteLine("What would you like to do?\n1. Celsius to Fahrenheit\n2. Fahrenheit to Celsius");
            string choice = Console.ReadLine();
            return choice;
        }

        static double GetTemp(string unit)
        {
            Console.Write($"Enter temperature in {unit}:");
            double temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }

        static void CelciusToFahrenheit(double temp)
        {
            Console.WriteLine($"That is {temp * 9/5 + 32} fahrenheit");
        }

        static void FahrenheitToCelcius(double temp)
        {
            Console.WriteLine($"That is {(temp - 32) * 5/9} celcius");
        }

        static void Exit()
        {
            Console.WriteLine("Press any key to exit...");
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
