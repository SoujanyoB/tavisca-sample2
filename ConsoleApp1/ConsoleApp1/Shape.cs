

namespace ConsoleApp1
{
    internal class Shape
    {
        public int width;
        public int height;

        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }
    }

    internal class Rectangle : Shape
    {
        public int GetArea()
        {
            return width * height;
        }
    }
}
