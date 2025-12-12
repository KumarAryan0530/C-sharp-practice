using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class GetSetExample
    {
        internal class GetSet
        {
            private int width;
            internal int _Width
            {
                get{
                    return this.width;
                }
                set{ 
                    this.width = value;
                }

            }
        }
        static void Main(String[] args)
        {
            GetSet obj = new GetSet();
            obj._Width = 200;
            Console.WriteLine("Width is: {0}", obj._Width);
        }
    }
}
