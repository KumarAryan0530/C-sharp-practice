using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class ArrayExample
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 3, 4, 7, 2 };
        //    Console.WriteLine("Array by For loop");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //    Console.WriteLine("For Each Loop");
        //    foreach(int i in arr)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //static void Main()
        //{
        //    int size;
        //    Console.WriteLine("Enter the size of the array: ");
        //    size = Convert.ToInt32 (Console.ReadLine());
        //    int[] arr = new int[size];
        //    for(int i=0;  i<arr.Length; i++)
        //    {
        //        Console.WriteLine("Enter Items: ");
        //        arr[i] = Convert.ToInt32(Console.ReadLine());

        //    }
        //    Console.WriteLine("Array elements are:");
        //    foreach(int i in arr)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        static void Main()
        {
            int size;
            Console.WriteLine("Enter the size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            String[] arr = new String[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Items: ");
                arr[i] = Console.ReadLine();

            }
            Console.WriteLine("Array elements are:");
            foreach ( String i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
