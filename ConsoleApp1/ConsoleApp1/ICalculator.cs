﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface ICalculator
    {
        public int Add(int a, int b);

        public int Sub(int a, int b);

        public int Mult(int a, int b);

        public double Div(int a, int b);
    }
}
