using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class Circle
    {
        public int param1;
        public float area;

        internal void Accept(int param1)
        {
            this.param1 = param1;
        }
        internal void CircleArea()
        {
            area = 3.14f * param1 * param1;
        }
        internal void Display()
        {
         
           Console.WriteLine("Area of Circle is: {0}", area);
        }

    }
}
