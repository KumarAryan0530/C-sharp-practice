using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class ForLoopExample
    {
        //static void Main()
        //{
        //    Console.WriteLine("For Loop Step Increment");
        //    for(int step = 1; step<=10; step++)
        //    {
        //        Console.WriteLine("Step " + step);
        //    }
        //    Console.WriteLine("For Loop Step Decrement");
        //    for(int step= 10; step>=1; step--)
        //    {
        //        Console.WriteLine("Step " + step);
        //    }
        //}

        //static void Main()
            
        //{
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 1; i<=10; i++)
        //    {
        //        Console.WriteLine(a * i);
        //    }
        //}

        //static void Main()
        //{
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    int r = 1;

        //    for(int i = a; i>1; i--)
        //    {
        //        r *= i;   
               
        //    }
        //    Console.WriteLine(r);

        //}
        static void Main()
        {
            int num = 123456;
            String str = "";
            do
            {
                str = str + num % 10;
                num = num / 10;
            } while (num != 0);
            Console.WriteLine("Reverse is: " + str);

        }
    }
}
