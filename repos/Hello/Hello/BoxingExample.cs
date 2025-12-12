using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class BoxingExample
    {
        internal void Boxing()
        {
            int a = 10;
            Object o; //Boxing
            o = a;
            Console.WriteLine("The value of object o after boxing is: " + o);
        }
        internal void Unboxing()
        {
            Object o = 10;
            int a = (int)o; //Unboxing
            Console.WriteLine("The value of integer a after unboxing is: " + a);
        }
    }
}
