using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class ConstructorExample
    {
        static int x, y;
        int a, b;
        static ConstructorExample()
        {
            int x = 100;
            int y = 200;
            Console.WriteLine("Static Default Constructor" + (x+y));
        }
        internal ConstructorExample()
        {
            int a = 10;
            int b = 50;
            Console.WriteLine("Default Constructor" + (a-b));
        }

        internal ConstructorExample(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Parameterized Constructor " + (a*b));
        }
        internal ConstructorExample(ConstructorExample c)
        {
            this.a = c.a;
            this.b = c.b;
            Console.WriteLine("Parameterized Constructor " + (a*b));
        }

        

    }
}
