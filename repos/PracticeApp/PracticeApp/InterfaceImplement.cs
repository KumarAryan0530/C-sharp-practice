using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class InterfaceImplement : IFirst, ISecond
    {
        //public void fun1()
        //{
        //    Console.WriteLine("Fun1");
        //}

        //public void fun2()
        //{
        //    Console.WriteLine("Fun2");
        //}

        //public void fun3()
        //{
        //    Console.WriteLine("Fun3");
        //}
        void IFirst.fun1()
        {
            Console.WriteLine("IFirst Fun1");
        }
        void IFirst.fun2()
        {
            Console.WriteLine("IFirst Fun2");
        }
        void ISecond.fun1()
        {
                Console.WriteLine("ISecond Fun1");
        }
        void ISecond.fun2()
        {
            Console.WriteLine("ISecond Fun2");

        }
        void ISecond.fun3()
        {
            Console.WriteLine("ISecond Fun3");
        }
    }
}
