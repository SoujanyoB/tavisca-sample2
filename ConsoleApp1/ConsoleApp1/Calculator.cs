
namespace ConsoleApp1
{
    internal class Calculator // : ICalculator
    {
        //internal double x;

        //public Calculator()
        //{
        //    x = 100;
        //}

        //public Calculator(double x)
        //{
        //    this.x = x;
        //}


        //public double Add(double a)
        //{
        //    return x + a;
        //}

        //public double Add(double a, double b, double c)
        //{
        //    return (x + a + b + c);
        //}


        //public double Add(double a, double b)
        //{
        //    return (x + a + b);
        //}

        //public double Subtract(double a)
        //{
        //    return (x - a);
        //}

        //public double Subtract(double a, double b)
        //{
        //    return (x - a - b);
        //}

        //public double Subtract(double a, double b, double c)
        //{
        //    return (x - a - b - c);
        //}

        //public double Multiply(double a)
        //{
        //    return x * a;
        //}

        //public double Multiply(double a, double b)
        //{
        //    return x * a * b;
        //}

        //public double Multiply(double a, double b, double c)
        //{
        //    return x * a * b * c;
        //}

        //public double Divide(double a)
        //{
        //    return x / a;
        //}

        //public double Divide(double a, double b)
        //{
        //    return (x / a) / b;
        //}

        //public double Divide(double a, double b, double c)
        //{
        //    return ((x / a) / b) / c;
        //}
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //public double Div(int a, int b)
        //{
        //    return a / (double)b;
        //}

        //public int Mult(int a, int b)
        //{
        //    return a * b;
        //}

        //public int Sub(int a, int b)
        //{
        //    return a - b;
        //}

        public int Add(params int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }

        public int Sub(params int[] nums)
        {
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                res -= nums[i];
            }

            return res;
        }

        public int Mult(params int[] nums)
        {
            int prod = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                prod *= nums[i];
            }

            return prod;
        }

        public double Divide(params int[] nums)
        {
            double res = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                res /= nums[i];
            }

            return res;
        }

        public void start()
        {
            int option;

            OUTER:
            Console.WriteLine("Enter number of elements: ");
            int len = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements");
            int[] arr = new int[len];

            for (int i = 0; i < len; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter option:\n1. Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Exit");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Sum: {0}", Add(arr));
                    goto OUTER;
                case 2:
                    Console.WriteLine("Difference: {0}", Sub(arr));
                    goto OUTER;
                case 3:
                    Console.WriteLine("Product: {0}", Mult(arr));
                    goto OUTER;
                case 4:
                    Console.WriteLine("Division: {0}", Divide(arr));
                    goto OUTER;
                default:
                    Environment.Exit(0);
                    break;
            }

        }

    }
}
