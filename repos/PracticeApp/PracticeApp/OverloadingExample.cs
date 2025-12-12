using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class OverloadingExample
    {
        void Add(int a, int b)
        {
            Console.WriteLine("Addition is: {0}", a + b);
        }
        void Add(int a, int b, int c)
        {
            Console.WriteLine("Addition is: {0}", a + b + c);
        }
        void Add(float a, float b)
        {
            Console.WriteLine("Addition is: {0}", a + b);
        }
        public static void Main(String[] args)
        {
            OverloadingExample obj = new OverloadingExample();
            obj.Add(10, 20);
            obj.Add(10, 20, 30);
            obj.Add(10.5f, 20.5f);
        }
    }
}
