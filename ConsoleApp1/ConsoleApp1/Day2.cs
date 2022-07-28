using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day2
    {
        /*
         * function to check if word ends with A or a
         */
        static void findIfNameEndsWithA()
        {
            Console.WriteLine("Enter name: ");
            string sentence = Console.ReadLine();

            sentence = sentence.Trim();

            if (sentence[sentence.Length - 1] == 'A' || sentence[sentence.Length - 1] == 'a')
            {
                Console.WriteLine("\"Sentence\" ends with A or a.");
            }
            else
            {
                Console.WriteLine("Sentence doesn't end with A or a.");
            }


        }

        /*
         * function to find number of words and letters
         */
        static void findNumberOfWordsInSentence()
        {

            Console.WriteLine("Enter sentence: ");
            string sentence = Console.ReadLine();

            sentence = sentence.Trim();
            int words = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    words++;

                }
            }


            Console.WriteLine("Number of words: {0}\nNumber of letters: {1}", words + 1, sentence.Length - words);
        }

        /*
         * function to reverse a name and display
         * Last name followed by first name
         */
        static void reverseNameDisplay()
        {
            Console.WriteLine("Enter first name: ");
            string FN = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            string LN = Console.ReadLine();

            Console.WriteLine($"{LN} {FN}");

        }

        /*
         * function to find index of Number from a List
         */
        static int findIndexOfNumberFromList(List<int> list, int num)
        {
            //for(int i = 0; i < list.Count; i++)
            // {
            //     if (list[i] == num)
            //     {
            //         return i;
            //     }
            // }

            // return -1;

            list.Sort();

            return binarySearch(list, 0, list.Count, num);
        }

        /*
         * function for binary search
         */
        static int binarySearch(List<int> list, int low, int high, int num)
        {
            // 1, 3, 6, 12, 45, 89 ; 6

            if (low < high)
            {
                int mid = (low + high) / 2;
                if (list[mid] == num)
                {
                    return mid;
                }
                else if (num > list[mid])
                {
                    return binarySearch(list, mid + 1, high, num);
                }
                else
                {
                    return binarySearch(list, low, mid, num);
                }
            }

            return -1;
        }

        /*
         * function to reverse a string
         */
        static string reverseString(string word)
        {
            string result = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }


            return result;
        }

        /*
         * function to implement generic sorted list
         * where key value pair datatype is specified
         */
        static void implementGenericSortedList()
        {

            SortedList<int, string> list = new SortedList<int, string>();

            list.Add(2, "hello");
            list.Add(1, "world");
            list.Add(3, "bye");
            list.Add(4, "tata");

            foreach (KeyValuePair<int, string> item in list)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

        }

        /*
         * function to implement HashTable
         */
        static void implementHashTable()
        {
            Hashtable table = new Hashtable();
            table.Add(1, "one");
            table.Add(2, "two");
            table.Add(3, "three");
            table.Add("four", 4);

            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            // the other way to print value
            Console.WriteLine((string)table[2]);

        }

        /*
         * function to implement stack
         * LIFO
         */
        static void implementStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("two");
            stack.Push(3.6);
            stack.Push(null);
            stack.Push(false);

            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }

        }

        /*
         * function to implement Queue
         * it follows FIFO
         */
        static void implementQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("two");
            queue.Enqueue(4.6);

            Console.WriteLine("Count: {0}", queue.Count);

            while (queue.Count != 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        }


        /*
         * function to implement a sorted list
         * it sorts itself automatically when new elements
         * are added
         */
        static void implementSortedList()
        {

            SortedList list = new SortedList();
            list.Add(3, "three");
            list.Add(2, "two");
            list.Add(4, "four");
            list.Add(1, "one");
            list.Add(5, "five");

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.GetKey(i) + " : " + list.GetByIndex(i));
            }

        }

        /*
         * function to implement random number generator
         * and sorting of the array from sort
         */
        static void implementSort()
        {

            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new Random().Next(50));
            }

            Console.WriteLine("Before sorting: ");

            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine("\nAfter sorting: ");

            list.Sort();

            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }



        }

        /*
         * function to implement type casting of objects
         */
        static void implementTypeCasting()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("two");
            array.Add(4.6454f);

            int first = (int)array[0];
            float last = (float)array[array.Count - 1];

            Console.WriteLine(last);
        }

        /*
         * function to implement arraylists
         * which don't type check
         */
        static void implementArrayList()
        {

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add(false);
            arrayList.Add(4.5);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.AddRange(new ArrayList() { 100, 200, 300 });

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

        }

        /*
         * function to remove item from a list
         */
        static void removeItemFromList()
        {
            List<int> list = new List<int>() { 1, 2, 3 };

            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine();

            list.Remove(list.Count - 1);

            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }

        }

        /*
         * function to implement question stated
         * to loop through 1 to 20 and print
         * el is odd/even for different elements
         */
        static void listQuestion()
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                list.Add(i);
            }

            //list.ForEach(el =>
            //{
            //    if (el % 2 == 0)
            //    {
            //        Console.WriteLine("{0} is even.", el);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} is odd.", el);
            //    }
            //});

            list.ForEach(el => Console.WriteLine("{0} is {1}.", el, el % 2 == 0 ? "even" : "odd"));
        }

        /*
         * function to implement different types of loops
         * to iterate through elements
         */
        static void implementDifferentLists()
        {

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(new List<int>() { 4, 5, 6, 7, 8 });

            // implementing list.foreach i.e., internal foreach of lists
            list.ForEach(el =>
            {
                Console.Write(el + "\t");
            });

            Console.WriteLine();


            // implementing foreach loop i.e., the normal library foreach
            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine();


            // implementing for loop for forward iteration
            for (var i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "\t");
            }

            Console.WriteLine();

            // implementing for loop for reverse iteration
            for (var i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i] + "\t");
            }

            Console.WriteLine();

            // implementing while loop
            int j = 0;
            while (j < list.Count)
            {
                Console.Write(list[j] + "\t");
                j++;
            }


        }

        /*
         * function to implement basic list
         */
        static void implementLists()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            list.ForEach(el => Console.Write(el + "\t"));
        }

    }
}
