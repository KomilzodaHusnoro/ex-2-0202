using System;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Rectangle 
    {
        double side1, side2, perimeter, area;
        public void Perimeter (double side1, double side2) 
        {
            perimeter = (side1 + side2)*2;
        }
        public void Area (double side1, double side2)
        {
            area = side1*side2;
        }
    }
}
