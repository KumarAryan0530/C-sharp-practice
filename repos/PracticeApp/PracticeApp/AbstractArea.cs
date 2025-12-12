using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal abstract class AbstractArea
    {
        internal int param1, param2;
        internal float area;
    
    internal void Accept(int param1, int param2)
        {
            this.param1 = param1;
            this.param2 = param2;
        }
        internal abstract void triangle();
        internal abstract void rectangle();

        internal void Display()
        {
                       Console.WriteLine("Area is: {0}", area);
        }

    }
}
