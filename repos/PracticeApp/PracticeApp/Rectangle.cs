using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class Rectangle: Triangle
    {
        internal void RectangleArea()
        {
            area = param1 * param2;
        }
        internal void Display3()
        {
            Console.WriteLine("Area of Rectangle is: {0}", area);
        }
    }
}
