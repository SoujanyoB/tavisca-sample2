using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Box
    {
        private double length;
        private double breadth;
        private double height;

        public Box() { }

        public Box(double length, double breadth, double height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void SetLength(double len)
        {
            length = len;
        }

        public void SetBreadth(double breadth)
        {
            this.breadth = breadth;
        }

        public void SetHeight(double h)
        {
            height = h;
        }

        // operator overloading
        public static Box operator +(Box a, Box b)
        {
            Box box = new Box();
            box.length = a.length + b.length;
            box.breadth = a.breadth + b.breadth;
            box.height = a.height + b.height;

            return box;
        }
    }
}
