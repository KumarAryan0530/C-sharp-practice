using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Swap
    {
        static int a = 5, b = 10;

        internal static void SwapValues()
        {
            int temp = a;
            a = b;
            b = temp;
           Console.WriteLine("Swapping the numbers a = {0} and b = {1}", a, b);
           Console.WriteLine($"Swapping the numbers a = {a} and b = {b}");
        }
    }
}
