//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeApp
//{
//    abstract class Shape
//    {
//        public abstract double Area();
//    }
//    class CircleH : Shape
//    {
//        private double Radius;
        
//        public CircleH(double radius)
//        {
//            this.Radius = radius;
//        }
//        public override double Area()
//        {
//            return Math.PI * Radius * Radius;
//        }
       
//    }
//    class Rectangle: Shape
//    {
//        public double Length;
//        public double Width;

//        public Rectangle(double length, double width)
//        {
//            this.Length = length;
//            this.Width = width;
//        }
//        public override double Area()
//        {
//            return Width * Length;
//        }
      
//    }
//    class Triangle: Shape
//    {
//        public double Base;
//        public double Height;

//        public Triangle(double baselen, double height)
//        {
//            this.Base = baselen;
//            this.Height = height;
//        }
//        public override double Area()
//        {
//            return 0.5 * Base * Height;
//        }
//        class Program2
//        {
//            static void Main()
//            {
//                Shape c = new CircleH(5);
//                Shape t = new Triangle(10, 6);
//                Shape r = new Rectangle(10, 10);

//                Console.WriteLine("Circle Area" + c.Area());
//                Console.WriteLine("Triangle Area" + t.Area());
//                Console.WriteLine("Reactangle Area" + r.Area());

//            }
//        }
//    }
    
//}

