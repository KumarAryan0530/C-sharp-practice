using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    public class AccessSpecifiers
    {
        private void Fun1()
        {
            Console.WriteLine("Private Fun1");
        }
        protected void Fun2()
        {
            Console.WriteLine("Protected Fun2");
        }
        protected internal void Fun3()
        {
            Console.WriteLine("Protected Internal Fun3");
        }
        internal void Fun4()
        {
            Console.WriteLine("Internal Fun4");
        }
        public void Fun5()
        {
            Console.WriteLine("Public Fun5");
        }
    }
}
