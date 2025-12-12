using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Employee obj = new Employee();
        //    //obj.Accept(1, "Emp 1", 22);
        //    //obj.Display();
        //    //Console.WriteLine(StaticExample.x);
        //    //StaticExample.fun();
        //    //InstanceExample obj1 = new InstanceExample();
        //    //Console.WriteLine(obj1.x);
        //    //obj1.fun();

        //    Student[] obj = new Student[5];
        //    for (int i = 0; i < 5; i++) 
        //    {
        //        obj[i] = new Student();
        //        Console.WriteLine("Enter Rno");
        //        int rno = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Enter Fees");
        //        int fees = Convert.ToInt32(Console.ReadLine());

        //        obj[i].Accept(rno, fees);

        //    }
        //    int max = 0;
        //    int stuindex = 0;

        //    for(int i = 0; i < obj.Length; i++)
        //    {
        //        if(max<obj[i].fees)
        //        {
        //            max = obj[i].fees;
        //            stuindex = i;
        //        }
        //    }
        //    Console.WriteLine("Student with max fees is:{0} ", max);
        //    obj[stuindex].Display();

        //}
        //static void Main(String[] args)
        //{
        //    ConstructorExample obj1 = new ConstructorExample(5, 10);
        //    ConstructorExample obj2 = new ConstructorExample(obj1); 
        //    Console.Write("hello");

        //}

        //static void Main(String[] args)
        // {
        // PropertyExample example = new PropertyExample(); //getter
        //     example.Width = 200; //setter
        //     Console.WriteLine("Width is: {0}", example.Width);
        // }
        //static void Main(String[] args)
        //{
        //    C obj = new C();
        //    obj.Fun1();
        //    obj.Fun();
        //    obj.Fun2();
        //}
        //static void Main(String[] args)
        //{
        //  Employees e = new  Employees(101, "Kumar Aryan", 50000, 5000);
        //  e.Display();
        //}
        
        //static void Main(String[] args)
        //{
        //   AbstractArea obj = new AbstractChild();
        //    obj.Accept(10, 2);
        //    obj.triangle();
        //    obj.Display();
        //}
        static void Main(String[] args)
        {
            AccessSpecifiers obj = new AccessSpecifiers();
            obj.Fun5();
            obj.Fun4();
            obj.Fun3();

        }
    }
}
