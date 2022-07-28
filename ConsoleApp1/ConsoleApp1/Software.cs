
namespace ConsoleApp1
{
    internal class Software
    {
        protected int m_x;

        

        public Software()
        {
            m_x = 100;
        }

        public Software(int x)
        {
            m_x = x;
        }
    }

    internal class MicrosoftSoftware : Software
    {
        public MicrosoftSoftware()
        {
            Console.WriteLine($"Default MS constructor: {m_x}");
        }

        public MicrosoftSoftware(int y) : base(y)
        {
            Console.WriteLine($"param MS constructor: {m_x}");
        }

        public MicrosoftSoftware(int y, int x) : this(x)
        {
            Console.WriteLine($"{y} : {m_x}");
        }
    }
}
