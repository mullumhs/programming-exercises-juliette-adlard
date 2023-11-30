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

            int x = 0;
            int y = 1;
            for (int i = 1; i < 1000; i = x + y)
            {
                Console.WriteLine(i);
                y = x;
                x = i;
            }

            // Wait for input before ending
            Console.ReadLine();
        }

        
    }
}
