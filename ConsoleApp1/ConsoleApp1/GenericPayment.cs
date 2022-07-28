using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GenericPayment
    {
        public GenericPayment()
        {
            Console.WriteLine("Generic payment constructor");
        }

        public virtual void Payment()
        {
            Console.WriteLine("Internet Banking");
        }
    }

    internal class GPay : GenericPayment
    {
        public GPay()
        {
            Console.WriteLine("Gpay Constructor");
        }

        public override void Payment()
        {
            Console.WriteLine("GPay");
        }
    }

    internal class PhonePe : GenericPayment
    {
        public PhonePe()
        {
            Console.WriteLine("PhonePe constructor");
        }

        public override void Payment()
        {
            Console.WriteLine("PhonePe");
        }
    }

    internal class CCPay : GenericPayment
    {
        public CCPay()
        {
            Console.WriteLine("CCPay constructor");
        }

        public override void Payment()
        {
            Console.WriteLine("Credit Card");
        }
    }
}
