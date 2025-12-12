using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        //int a = 10;
        static void Greet(string name) //static tells that the method belongs to the current class
        {
            Console.WriteLine("Good Morning Gokuldham " + name);
        } 

        static float Average(int a, int b , int c)
        {
            float sum = a + b + c;
            return sum / 3;

        }
        static float Average(int a , int b)
        {
            return (a + b) / 2;
        }
        static void Main(string[] args)
        {

            // Single line comment example - This is important for debugging. Do not remove this.

            /* Multi line Comment Example 
             * This is a multi line comment example
             */


            // int aryan = 34; // Integer variable
            // string inp = Console.ReadLine();
            // Console.WriteLine(inp);
            // Console.WriteLine("Hello World");
            // Console.Write("Hello Aryan");
            // Console.WriteLine("I love C# and the number" + aryan);


            // Data Types Examples
            // int a = 34;
            // float b = 34.4F;
            // double c = 34.4D;
            // bool isGreat = true;
            // char d = 'r';
            // string e = "this is a string";
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);


            // Type Casting
            // There are two types of type casting
            // 1. Implicit Casting
            // char to int to long to float to double

            // 2. Explicit Casting
            //int x = (int)3.5;
            //double x1 = (double)3.5;
            //Console.WriteLine(x1);

            // int x = 3;
            // double y = 4;
            // float z = 'y';
            // float varrr = Convert.ToInt64(3.55);
            // Convert.ToDouble
            // Convert.ToString
            // string sx = "Random string";


            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(isGreat);
            // Console.WriteLine(d);
            // Console.WriteLine(e);


            //How take user input
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey Hello " + name);

            //Console.WriteLine("How many candies do you want?");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies: " +
            //        (Convert.ToInt32(can) + 4));


            /* Operators in C#
             1. Arithmetic Operators
             2. Assignment Operators
             3. Logical Operators
             4. Comparison Operators
             */

            //int a = 4;
            //int b = 2;
            //Console.WriteLine("The value of a + b is: "  + (a + b));
            //Console.WriteLine("The value of a + b is: "  + (a - b));
            //Console.WriteLine("The value of a + b is: " + (a * b));
            //Console.WriteLine("The value of a + b is: " + (a / b));


            // Assignment Operators

            //int a = 4;
            //int b = a;
            //b += 4;
            //b -= 4;
            //b *= 4;
            //b /= 4;

            //Console.WriteLine(b);


            //Logical Operators
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.WriteLine(false || true);

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);


            //Comparison Operators
            //Console.WriteLine(324 > 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 != 555);
            //Console.WriteLine(555 == 555);

            //Math Class
            //int a = Math.Max(34, 345);
            //int b = Math.Min(34, 345);
            //double c = Math.Sqrt(39);
            //int d = Math.Abs(-39);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);


            //string hello = "Hello world this is Kumar aryan";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + "You are nice");
            //Console.WriteLine(string.Concat(hello, "You are nice"));


            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();

            //Console.WriteLine($"Your name is {name}. You will get {candies} candies"); //String Interpolation

            //string hello = "Hello world this \n \" \t Kumar Aryan";
            ////Console.WriteLine(hello[1]);
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(5));
            //Console.WriteLine(hello);

            //Console.WriteLine("Enter your age ");
            //string ageStr = Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);
            //bool isBanned = true;
            //if(age>18 )

            //{
            //    Console.WriteLine("You can drive");

            //}
            //else if(age < 2 || isBanned)
            //{
            //    Console.WriteLine("You just born and you are banned from driving");

            //}
            //else if(age < 10 || isBanned)
            //{
            //    Console.WriteLine("Complete your high school first and till then you are banned");

            //}
            //else if (age < 18 || isBanned)
            //{
            //    Console.WriteLine("You are below 18 and you are banned");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot drive and you are banned");
            //}

            //int age = 20;

            //switch(age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for an year");
            //        break;
            //    case 20:
            //        Console.WriteLine("You are 20");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy");
            //        break;
            //}


            // Loops in C#
            // while Loops

            //int i = 0;
            //while (i < 5000)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}

            //int i = 0;
            //do //ek baar chalega hi chalega 
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //}
            //while (i < 5000); 

            // intitialization; condition checking; update
            //for(int i=0; i<5; i++)
            //{
            //    if(i == 0)
            //    {
            //        continue;
            //    }
            //    //continue;// iske neecche jo bhi likha hain usko bhul jao or next iteration ko run karo
            //    Console.WriteLine(i+1);
            //    //break;
            //}

            //Break and Continue

            // Break - Leave this loop forever 
            //// Leave this paerticular iteration of the loop
            //Greet("Kumar Aryan");
            //Greet("Rahul Raj");
            //Console.WriteLine(Average(2,3,5));
            //float temp = Average(9, 3, 0);
            //Console.WriteLine(temp);
            //Console.WriteLine(Average(3,3,3));
            //Console.WriteLine(Average(2, 2));


            // OOPs - Classes and objects

            //Player tommy = new Player();
            //Console.WriteLine(tommy.getHealth());
            //tommy.setHealth(57);
            //Console.WriteLine(tommy.getHealth());
            //Console.ReadLine();
            //Program obj = new Program();
            ////Console.WriteLine("a is the " + obj.a);

            //Swap.SwapValues();

            //SimpleInterest si = new SimpleInterest();
            //si.Interest();

            BoxingExample bx = new BoxingExample();
            bx.Boxing();
            bx.Unboxing();

            Datatype obj = new Datatype();
            obj.PDatatypeFun();
            obj.DDatatypeFun();

        }
    }
}
