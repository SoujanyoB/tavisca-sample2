using System;

namespace Day9
{
    public class Program
    {
        public static async Task Main()
        {

            // Implementing long and short process
            // with thread sleep

            //Task<int> result = LongProcess();

            //ShortProcess();

            //var val = await result;

            //Console.WriteLine($"Result: {val}");

            //Console.ReadKey();


            //Console.WriteLine("Enter date of birth:\nNote: The format should be in [DD/MM/YYYY] or [DD-MM-YYYY] or [DD.MM.YYYY]");
            //string dob = Console.ReadLine();

            //int age = ageCalculator(dob);
            //if(age != -1)
            //{
            //    Console.WriteLine($"\n\nAge is : {age}");
            //} else
            //{
            //    Console.WriteLine("Date is not in the right format! Try again!");
            //}


            //Mydelegate d1 = A.hello;
            //Mydelegate d2 = B.hello;

            //Mydelegate d = d1 - d2;
            ////d("hello world!");

            ////d = d1 - d2;
            //d("hello world!");

            //SendMessage d1 = SendEmail.SendEmailToCustomer;
            //SendMessage d2 = SendSMS.SendSMSToCustomer;
            //SendMessage d3 = SendMessageToInventory.RemoveProdFromInventory;

            //SendMessage d = d1 + d2 + d3;
            //d("Samsung Galazy Note 12");

            /*
             * func keyword can work as a delegate
             * that is we don't have to pre-define the delegate
             * the datatype of func includes the inputs of the function we want it to hold
             * followed by the datatype of the output
             */
            //Func<int, int, int> add = implementSum;
            //int res = add(1, 2);
            //Console.WriteLine(res);

            //Action<string> actionDelegate = ConsolePrint;
            //actionDelegate("ehlo");

            // operator overloading
            //Box a = new Box(1, 2, 3);
            //Console.WriteLine($"Volume of Box A: {a.getVolume()}");

            //Box b = new Box(1, 2, 3);
            //Console.WriteLine($"Volume of Box B: {b.getVolume()}");

            //Box box = a + b;
            //Console.WriteLine($"Volume of Box C: {box.getVolume()}");


            Student a = new Student(10);
            Student b = new Student(12);

            Console.WriteLine(a > b);
            Console.WriteLine(a < b);

            a.SetID(23);
            a.SetFirstName("Soujanyo");
            a.SetLastName("Biswas");
            a.SetLocation("Pune");


            try
            {
                a.displayInformation();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       

        static void ConsolePrint(string msg)
        {
            Console.WriteLine(msg);
        }

        static int implementSum(int a, int b)
        {
            return a + b;
        }

        public delegate void SendMessage(string order);

        class SendEmail
        {
            public static void SendEmailToCustomer(string msg)
            {
                Console.WriteLine($"Your order {msg} invoice has been sent to your email.");
            }
        }

        class SendSMS
        {
            public static void SendSMSToCustomer(string msg)
            {
                Console.WriteLine($"Your order {msg} invoice has been forwarded as SMS to your phone!");
            }
        }

        class SendMessageToInventory
        {
            public static void RemoveProdFromInventory(string msg)
            {
                Console.WriteLine($"Your order {msg} invoice has been removed from inventory!");
            }
        }



        public delegate void Mydelegate(string message);

        class A
        {
            public static void hello(string msg)
            {
                Console.WriteLine("A class method: " + msg);
            }
        }

        class B
        {
            public static void hello(string msg)
            {
                Console.WriteLine("B class method: " + msg);
            }
        }
        


        /*
         * function to display age of a person from date of birth
         */
        static int ageCalculator(string dob) {

            try
            {
                int day = int.Parse(dob.Substring(0, 2));

                int month = int.Parse(dob.Substring(dob.IndexOfAny(new char[] { '/', '-', '.' }) + 1, 2));

                int year = int.Parse(dob.Substring(dob.LastIndexOfAny(new char[] { '/', '-', '.' }) + 1, 4));

                DateTime date = new DateTime(year, month, day);

                return (int)(DateTime.Now.Subtract(date).TotalDays / 365.2425);
            } catch
            {
                return -1;
            }
        }


        /*
         * Implementing thread.sleep()
         */

        static async Task<int> LongProcess()
        {
            Console.WriteLine(DateTime.UtcNow);
            //Thread.Sleep(2000);
            await Task.Delay(3000);
            Console.WriteLine(DateTime.UtcNow);

            return 100;
        }

        static void ShortProcess()
        {
            Console.WriteLine("Short process bruh");
        }
    }
}