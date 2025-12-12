using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Pattern
    {
        //static void Main()
        //{
        //    for(int i = 1; i <= 5; i++)
        //    {
        //        for (int j = 1; j <= 5; j++)
        //        {
        //            Console.Write("j");
        //        }
        //        Console.WriteLine();

        //    }
        //}
        //static void Main()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        for (int j = 1; j <= 5; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();

        //    }
        //}
        //static void Main()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();

        //    }
        //}
        //static void Main()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write(i);
        //        }
        //        Console.WriteLine();

        //    }
        //}
        //static void Main()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        for (int j = 1; j <= 6 - i; j++)
        //        {
        //            if(i%2!= 0)
        //                Console.Write(j);
        //            else
        //                Console.Write(6-j);
        //        }
        //        Console.WriteLine();

        //    }
        //}
        //static void Main()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        char ch = 'A';
        //        for (int j = 1; j <= 6 - i; j++)
        //        {
             
        //            if (j % 2 != 0)
        //                Console.Write(ch);
        //            else
        //            {
        //                Console.Write((char)(ch + 32));
        //                ch++;
        //            }
                        
        //        }
        //        Console.WriteLine();

        //    }
        //}
        static void Main()
        {
            for(int i =1; i<=3; i++)
            {
                for(int space = 2; space>=i; space--)
                {
                    Console.Write(" ");
                }
                for (int j =1; j<=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            for (int i = 2; i >= 1; i--)
            {
                for (int space = 2; space >= i; space--)
                    Console.Write(" ");

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }


    }

}

