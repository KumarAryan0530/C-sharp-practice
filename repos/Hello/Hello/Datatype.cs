using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Datatype
    {
        public void PDatatypeFun()
        {
            int a = 10; // 4 byte
            byte bt = 2; // 1byte
            float b = 32.2F; //4 byte 
            double c = 4523224.3D; //8 byte
            bool d = false; //1 byte
            char ch = 'A';// 2byte
            string s = "hello";
            Console.WriteLine("a={0}, b={1}, c={2}, d={3}, ch={4}", a, b, c, d, ch);
        }
        public void DDatatypeFun()
        {
            Int16 a = 1;
            Byte b = 2; //1 byte
            Double d = 233.7F;
            Boolean d1 = false;
            Char ch = 'a';
            String s = "hello";
            Object o = 12;
            Console.WriteLine("a={0}, b={1}, c={2}, d={3}, ch={4}", a, b, ch, d, s);

        }
    }
}
