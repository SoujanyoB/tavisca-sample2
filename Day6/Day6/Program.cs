
namespace Day11
{
    public class Program
    {
        public static void Main()
        {

            //implementImplicitConversion();

            //implementExplicitConversion();

            //employee employee = new employee(1);

            //employee.GetId();

            //int i = 50;

            //Console.WriteLine(i.isGreaterThan(100));

            //List<int> ints = new List<int>() { 100, 20, 50 };

            //Console.WriteLine(ints.isIndexSmaller(21, 1));

            //string word = "hello";
            //Console.WriteLine(word.reverse());

            //implementTryCatch();

            //Student s = null;

            //try
            //{
            //    implementThrow(s);
            //} catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Student s = new Student();
            //s.Age = 2;

            //try
            //{
            //    implementCustomException(s);
            //} catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //s.Age = 8;

            //try
            //{
            //    implementCustomException(s);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //s.Age = 27;

            //try
            //{
            //    implementCustomException(s);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            int[] arr = new int[] { 1, 4, 6, 5, 2 };
            print(arr);
            implementBubbleSort(arr);
            print(arr);

            alaphabetSort();

            Console.WriteLine("\n\nEnter number of words: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter string: ");
                string word = Console.ReadLine();
                Console.WriteLine(countZ(word));
            }

        }

        static bool countZ(string word)
        {
            

            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'z')
                    count++;
            }

            if(count > 1 && count < 5)
            {
                return true;
            }

            return false;
        }

        static void alaphabetSort()
        {
            Console.WriteLine("Enter the number of characters: ");
            int len = int.Parse(Console.ReadLine());

            int[] letters = new int[len];

            Console.WriteLine("Enter the characters");
            for(int i = 0; i < len; i++)
            {
                letters[i] = Console.Read();
            }


            implementBubbleSort(letters);

            for(int i = 0; i < len; i++)
            {
                Console.Write(Convert.ToChar(letters[i]) + "\t");
                //Console.Write(letters[i] + "\t");
            }

            Console.WriteLine();



        }
        
        /*
         * 
         */
        static void print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }

        /*
         * function to implement Bubble Sort
         */
        static void implementBubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }

        class Student
        {

            public int Id { get; set; }

            public int Age { get; set; }
        }

        static void implementCustomException(Student s)
        {
            
            if (s.Age < 4)
                throw new Exception("Too small for studying");
            else if (s.Age > 25)
                throw new Exception("Too old for studying! Go find a job!");
            else
                Console.WriteLine("You're fit for the school. Welcome!");
        }

        static void implementThrow(Student s)
        {
            if (s == null)
                throw new NullReferenceException("String is null");

            Console.WriteLine(s);
        }


        static void implementTryCatch()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                
                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Square of {num} is: {num * num}");
            } catch { 
                Console.WriteLine("Error occured!");
            } finally
            {
                Console.WriteLine("Re-try with a different number!");
            }
        }

        

        /*
         * implementation of struct
         */
        struct Employee
        {
            public int id;

            public void GetId()
            {
                Console.WriteLine($"Employee id is: {id}");
            }

            public Employee(int id)
            {
                this.id = id;
            }
        }


        /*
         * function to implement Explicit type conversion
         */
        static void implementExplicitConversion()
        {
            double number = 500.22;

            Type typeDouble = number.GetType();

            int num = (int) number;

            Type typeInt = num.GetType();

            

            Console.WriteLine($"Number: {number}\nDatatype: {typeDouble}\n\n\nNumber: {num}\nDatatype: {typeInt}");

            Console.WriteLine("\n\nString to int: \n\n");

            string hello = "100";

            int helloNum = int.Parse(hello);

            int helloNumConvert = Convert.ToInt32(hello);

            Console.WriteLine($"String: {hello}\nType: {hello.GetType()}\n\nNumber: {helloNum}\nType: {helloNum.GetType()}");
        }

        /*
         * function to implement Implicit type casting
         */
        static void implementImplicitConversion()
        {
            int num = 500;

            Type typeInt = num.GetType();

            double number = num;

            Type typeDouble = number.GetType();

            Console.WriteLine($"Number: {num}\nDatatype: {typeInt}\n\n\nNumber: {number}\nDatatype: {typeDouble}");
        }
    }

    public static class IntExtenstions
    {
        public static bool isGreaterThan(this int i, int val)
        {
            return i > val;
        }

        public static bool isIndexSmaller(this List<int> ints, int val, int index)
        {
            return ints[index] < val;
        }
    }

    public static class StringExtenstions
    {
        public static string reverse(this string word)
        {
            char[] words = word.ToCharArray();
            for(int i = 0; i < words.Count() / 2; i++)
            {
                char temp = word[i];
                words[i] = word[word.Length - i - 1];
                words[word.Length - i - 1] = temp;
            }

            return new string(words);
        }
    }

}