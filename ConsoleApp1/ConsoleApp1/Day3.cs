using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day3
    {
        static void removeDuplicates(List<int> array)
        {

            Hashtable visited = new Hashtable();

            for (int i = 0; i < array.Count; i++)
            {
                if (!visited.ContainsKey(array[i]))
                {
                    visited.Add(array[i], true);
                }
                else
                {
                    array.Remove(array[i]);
                }
            }
        }


        static void implementAlphabetSort()
        {

            List<char> arr = new List<char>();

            Console.WriteLine("Enter size of array: ");

            int len = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter characters...");

            for (int i = 0; i < len; i++)
            {
                int let = Console.Read();
                char letter = Convert.ToChar(let);
                arr.Add(letter);
            }

            arr.Sort();

            arr.ForEach(el => Console.Write($"{el}\t"));


        }

        static List<int> implementArraySquare(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                array[i] *= array[i];
            }

            return array;
        }

        static void print(List<int> array)
        {
            array.ForEach(el => Console.Write($"{el}\t"));
        }

        static void implementMultiplicationTable()
        {
            Console.WriteLine("Enter number for multiplication table: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }


        static void implementSwitchCase()
        {

            int val = 5;
            switch (val)
            {
                case 1:
                    Console.WriteLine("found 1");
                    break;
                case 2:
                    Console.WriteLine("found 2");
                    break;
                case 5:
                    Console.WriteLine("found 5");
                    break;
                default:
                    Console.WriteLine("did not find!");
                    break;

            }

        }
    }
}
