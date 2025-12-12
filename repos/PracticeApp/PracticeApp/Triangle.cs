using System;

namespace PracticeApp
{
    internal class Triangle : Circle
    {
        public int param2;
        internal void Accept2(int param2)
        {
            this.param2 = param2;
        }
        internal void TriangleArea()
        {
            area = (param1 * param2) / 2;
        }
        internal void Display2()
        {

            Console.WriteLine("Area of Triangle is: {0}", area);
        }
    }
}
