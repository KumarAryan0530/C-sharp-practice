using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class Employee
    {
        private int empid;
        private string empname;
        private int age;

        internal void Accept(int empid, String empname, int age)
        {
            this.empid = empid;
            this.empname = empname;
            this.age = age;
        }
       internal void Display()
        {
            Console.WriteLine("Id {0}, Name:{1} and Age {2}", empid, empname, age);
        }
    }
}
