using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class SimpleInterest
    {
       
        internal void Interest()
        {
            double principal = 10000, rate = 5, time = 2;
            double simpleInterest = (principal * rate * time) / 100;
            Console.WriteLine("The Simple Interest is: " + simpleInterest);


        }
    }
}
