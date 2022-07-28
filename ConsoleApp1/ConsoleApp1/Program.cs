using System.Collections;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // checkIfTired();
            // displayNumber();
            // logicalOperators();

            // implement class
            // Student student = new Student();
            // student.FirstName = "Hello";
            // student.LastName = "World";



            // student.Age = 10;

            // student.displayInfo();

            // Student student2 = new Student();
            // student2.Age = 15;
            // student2.displayInfo();

            // Calculator calculator = new Calculator();

            // Console.WriteLine(calculator.Add(10, 15));
            // Console.WriteLine(calculator.Subtract(10, 15));

            /***************************************************/
            /*                      Day 2                      */
            /***************************************************/

            //implementLists();

            //implementDifferentLists();

            //listQuestion();

            //removeItemFromList();

            //implementArrayList();

            //implementTypeCasting();

            //implementSort();
            //implementSortedList();

            //implementQueue();

            //implementStack();

            //implementHashTable();

            //implementGenericSortedList();

            //Console.WriteLine("Reverse of {0} is {1}.", "hello", reverseString("hello"));

            //Console.WriteLine(findIndexOfNumberFromList(new List<int> { 1, 3, 45, 6, 89, 12 }, 6));

            //reverseNameDisplay();

            //findNumberOfWordsInSentence();

            //findIfNameEndsWithA();

            /***************************************************/
            /*                      Day 3                      */
            /***************************************************/

            //int x = 1;
            //Increment(ref x);
            //Console.WriteLine(x);

            //Rectangle rect = new Rectangle();
            //rect.SetWidth(10);
            //rect.SetHeight(5);

            //Console.WriteLine("Area of the rectangle is: {0}", rect.GetArea());

            //Employee employee = new Employee();
            //employee.GetDeptName("Software Trainee");
            //employee.GetDeptLocation("Pune");
            //employee.GetDeptDetails();

            //Employee employee1 = new Employee("Soujanyo", "Biswas", "Software Trainee", "Pune");
            //employee1.GetDeptDetails();

            //Animal animal = new Animal();
            //animal.Talk();
            //animal.Greet();
            //animal.Sing();

            //Console.WriteLine("Dog starts here....");

            //Dog dog = new Dog();
            //dog.Greet();
            //dog.Sing();

            //Console.WriteLine("Animal Dog starts here....");
            //Animal an = new Dog();
            //an.Sing();

            //GenericPayment gp = new GenericPayment();
            //gp.Payment();

            //GPay gpay = new GPay();
            //gpay.Payment();

            //PhonePe phonePe = new PhonePe();
            //phonePe.Payment();

            //CCPay cCPay = new CCPay();
            //cCPay.Payment();

            //Software software = new Software(23);

            //Software software1 = new MicrosoftSoftware();

            //Software software2 = new MicrosoftSoftware(12);

            //Software software3 = new MicrosoftSoftware(69, 420);


            //Math math = new Math(1, 1.2);
            //Math math1 = new Math(1.2, 3.4);
            //Math math2 = new Math(2, "2");

            //Calculator calculator = new Calculator(100);

            //// add
            //Console.WriteLine(calculator.Add(1));
            //Console.WriteLine(calculator.Add(1, 2));
            //Console.WriteLine(calculator.Add(1, 2, 3));

            //// subtract
            //Console.WriteLine(calculator.Subtract(1));
            //Console.WriteLine(calculator.Subtract(1, 2));
            //Console.WriteLine(calculator.Subtract(1, 2, 3));

            //// multiply
            //Console.WriteLine(calculator.Multiply(1));
            //Console.WriteLine(calculator.Multiply(1,2));
            //Console.WriteLine(calculator.Multiply(1, 2, 3));

            //// divide
            //Console.WriteLine(calculator.Divide(1));
            //Console.WriteLine(calculator.Divide(1,2));
            //Console.WriteLine(calculator.Divide(1, 2 ,3));

            //implementSwitchCase();

            //implementMultiplicationTable();

            //Console.WriteLine();

            //List<int> array = new List<int>() { 1, 2, 3, 4 };
            //implementArraySquare(array);
            //print(array);

            //Console.WriteLine();

            //implementAlphabetSort();

            //Console.WriteLine();

            //List<int> arr = new List<int>() { 1, 3, 2, 4, 2, 5 };
            //removeDuplicates(arr);
            //print(arr);


            /***************************************************/
            /*                      Day 4                      */
            /***************************************************/


            // implement return
            //Console.WriteLine(Addition(5, 6));
            //implementStringBuilder();

            //int num;

            //implementOut(out int num);

            //Console.WriteLine($"Number is {num}");

            List<int> array = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; ;

            //array = reverseArray(array);

            //array.ForEach(el => Console.Write(el + "\t"));

            //List<List<int>> res = splitArray(array);

            //res.ForEach(list =>
            //{
            //    list.ForEach(el => Console.Write(el + "\t"));
            //    Console.WriteLine();
            //});


            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 2));
            //Console.WriteLine(calculator.Sub(1, 2));
            //Console.WriteLine(calculator.Mult(1, 2));
            //Console.WriteLine(calculator.Div(1, 2));

            //DerivedClass derivedClass = new DerivedClass();
            //int add = derivedClass.Addition(2, 4);
            //int mult = derivedClass.Multiply(2, 4);
            //Console.WriteLine("{0} is addition and {1} is multiplication.", add, mult);

            //Calculator calculator = new Calculator();
            //calculator.start();

            //SoftwareEngg engg = new SoftwareEngg();
            //engg.SetFirstName("Soujanyo");
            //engg.SetLastName("Biswas");
            //engg.SetLocation("Pune");
            //engg.showInfo();
            //engg.FollowsDesignPrinciples();

            //HR hr = new HR();
            //hr.SetFirstName("Sameer");
            //hr.SetLastName("Jadhav");
            //hr.SetLocation("Pune");
            //hr.showInfo();
            //hr.HasGoodCommunicationSkills();







        }









        class File1
        {
            public virtual void hello()
            {
                Console.WriteLine("helllo");
            }
        }

        private partial class Record : File1
        {
            private int w;
            private int h;

            public Record(int w, int h)
            {
                this.w = w;
                this.h = h;
            }

            sealed public override void hello()
            {
                Console.WriteLine("hellllllllo");
            }
        }

        //class Temp : Record
        //{
        //    public Temp(int w, int h) : base(w, h) { }

        //    public override void hello()
        //    {

        //    }
        //}

        

        /*
         * Hierarchical inheritance
         */

        private class Employee
        {
            private string FirstName, LastName, Location;

            public void SetFirstName(string FN)
            {
                FirstName = FN;
            }

            public void SetLastName(string LN)
            {
                LastName = LN;
            }

            public void SetLocation(string loc)
            {
                Location = loc;
            }

            public void showInfo()
            {
                Console.WriteLine("Name: {0} {1}\nLocation: {2}", FirstName, LastName, Location);
            }

            public string GetFirstName()
            {
                return FirstName;
            }




        }

        private class HR : Employee
        {
            private bool hasMBA;

            public void HasGoodCommunicationSkills()
            {
                Console.WriteLine("{0} has good communication skills.", base.GetFirstName());
            }

            public void SetHasMBA(bool hasMBA)
            {
                this.hasMBA = hasMBA;
            }
        }

        private class SoftwareEngg : Employee
        {
            private bool isANerd, isGoodAtCoding;

            public void FollowsDesignPrinciples()
            {
                Console.WriteLine("{0} follows good design principles.", base.GetFirstName());
            }

            public SoftwareEngg()
            {
                isANerd = true;
                isGoodAtCoding = true;
            }
        }

       
        /*
         * function to split an array into two parts
         * and reverse the latter one
         */
        static List<List<int>> splitArray(List<int> array)
        {

            List<int> first = new List<int>();
            List<int> second = new List<int>();

            int i = 0;
            for(; i < array.Count/2; i++)
            {
                first.Add(array[i]);
            }

            for(; i < array.Count; i++)
            {
                second.Add(array[i]);
            }

            second = reverseArray(second);

            return new List<List<int>>() { first, second };

        }

        /*
         * function to reverse an array
         */
        static List<int> reverseArray(List<int> array)
        {
            for (int i = 0; i < array.Count / 2; i++) {
                int temp = array[i];
                array[i] = array[array.Count - i - 1];
                array[array.Count - i - 1] = temp;
            }

            return array;
        }

        static void implementOut(out int num)
        {
            num = 40;
            num *= 2;
        }

        static void implementStringBuilder()
        {
            StringBuilder s = new StringBuilder("Hello ", 20);

            //s.Append("Soujanyo Biswas agaooasdsad  asdsad sa");

            s.Insert(0, "asdg y asud usa yasud usadsagdgd g adgsad g");

            //s.Clear();

            s.Replace('a', 'z');
            
            Console.WriteLine(s);
        }

        static int Addition(int a, int b)
        {
            return (a + b);
        }



        static void Increment(ref int x)
        {
            x = x + 1;
        }




        

    }

    abstract class AbsClass
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        abstract public int Multiply(int a, int b);
    }

    class DerivedClass : AbsClass
    {
        public override int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}