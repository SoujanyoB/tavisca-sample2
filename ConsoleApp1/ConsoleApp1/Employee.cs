using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee : IEmployee
    {

        public void GetFirstName()
        {
            Console.WriteLine("Soujanyo");
        }

        public void GetLastName()
        {
            Console.WriteLine("Biswas");
        }

    }
}
