using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day1
    {
        /*
         * function to test logical operators
         */
        static void logicalOperators()
        {
            int a = 1;
            int b = 3;

            if (!(a == 1 && b == 2))
            {
                Console.WriteLine(true);
            }

            if (a != 1 || b != 2)
            {
                Console.WriteLine(true);
            }
        }

        /*
         * function to display a number
         */
        static void displayNumber()
        {
            Console.WriteLine("Enter a number: ");

            var input = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\nYou entered {0}", input);


        }

        /*
         * function to check if tired based on number of sleep
         */
        static void checkIfTired()
        {
            Console.WriteLine("Hi! Enter your name: ");
            var input = Console.ReadLine();

            Console.WriteLine("\nHow many hours of sleep did you have last night?");
            var sleep = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHi, {0}!", input);

            if (sleep >= 8)
            {
                Console.WriteLine("You seem well rested!");
            }
            else
            {
                Console.WriteLine("You must be very tired!");
            }
        }
    }
}
