using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class Student
    {
        private int rno;
        internal int fees;

        internal void  Accept(int rno, int fees)
        {
            this.rno = rno;
            this.fees = fees;
        }
        internal void Display()
        {
            Console.WriteLine("Rno {0}, Fees:{1}", rno, fees);
        }
    }
}
