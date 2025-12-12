using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class InstanceExample
    {
        internal int x = 100; //global instance variable

        internal void fun()
        {
            int y = 200; //local instance variable 
            Console.WriteLine(y);
        }
    }
}
