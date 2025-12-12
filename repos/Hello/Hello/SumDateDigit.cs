using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class SumDateDigit
    {
        //public static void Main()
        //{
        //    String date1 = "16092016";
        //    int d1 = Convert.ToInt32(date1);

        //    int sum = 0;
        //    while (d1 != 0)
        //    {
        //        int first = (int)d1 % 10;
        //        d1 = (int)d1 / 10;
        //        sum += first;
        //    }

        //    Console.WriteLine(sum);

        //    //    //int first = (int) d1 % 10; //6
        //    //    //d1 = (int) d1 / 10; //1609201
        //    //    //int second = d1 % 10; //1
        //    //    //d1 = (int) d1 / 10; //160920
        //    //    //int third = d1 % 10; //0
        //    //    //d1 =(int) d1 / 10;//16092
        //    //    //int fourth = d1 % 10;//2
        //    //    //d1 = (int)d1 / 10;//1609
        //    //    //int fifth = d1 % 10;//9
        //    //    //d1 = (int) d1 / 10;//160
        //    //    //int sixth = d1 % 10;//0
        //    //    //d1 = (int) d1 / 10;//16
        //    //    //int seventh = d1 % 10;//6
        //    //    //d1 = (int) d1 / 10;//1
        //    //    //int eighth = d1 % 10;

        //    //    //Console.WriteLine("Sum of digits in date is: " + (first + second + third + fourth + fifth + sixth + seventh + eighth));


        //    //}
        //    //public static void Main()
        //    //{
        //    //    int a = 10;
        //    //    int b = a++ + a++ + a++;
        //    //    Console.WriteLine("a={0} and b ={1}", a, b);
        //}


        //public static void Main()
        //{
        //    int a = 2000;
        //    string output = (a%400 == 0) || (a%4 == 0 && a%100 != 0) ? "Leap Year" : "Not a Leap Year";
        //    Console.WriteLine(output);
        //}
        //public static void Main()
        //{
        //    int a;
        //    a = Convert.ToInt32(Console.ReadLine());
        //    String output = (a % 3 == 0 && a % 5 == 0) ? "divisible by both" : (a % 3 == 0) ? "divisible by 3" : (a % 5 == 0) ? "divisible by 5" : "not divisible by both ";
        //    Console.WriteLine(output);    
        //}

        //public static void Main()
        //{
        //    int year = 2000;
        //    if (year % 400 == 0)
        //    {
        //        Console.WriteLine("Leap Year");
        //    }
        //    else if (year % 4 == 0 && year % 100 != 0)
        //    {
        //        Console.WriteLine("Leap Year");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not a Leap Year");

        //    }
        //}
        public static void Main()
        {
            char ch = 'a';
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowels");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;

            }

        }
    }
}