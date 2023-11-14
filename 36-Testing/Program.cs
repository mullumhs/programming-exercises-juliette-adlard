using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Testing
{
    internal class Program
    {
        // USE THIS FILE FOR TESTING AND EXPERIMENTATION

        static void Main(string[] args)
        {
            // Write your code here

            Console.WriteLine(Fibonnaci(2));


            // Wait for input before ending
            Console.ReadLine();
        }

        static int Fibonnaci(int n)
        {
            return (n - 1) + (n - 2);
        }
    }
}
