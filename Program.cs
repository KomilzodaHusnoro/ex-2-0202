using System;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first side of rectangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second side of rectangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle Pryamougolnik = new Rectangle(side1, side2);
            Pryamougolnik.PerimeterCulk(side1, side2);
            Pryamougolnik.AreaCulk(side1, side2);
            Console.WriteLine(Pryamougolnik.Perimeter);
            Console.WriteLine(Pryamougolnik.Area);

        }
    }
    class Rectangle 
    {
        double side1, side2, perimeter, area;
        public double Area{get{return area;} }
        public double Perimeter{get{return perimeter;} }
        public Rectangle(double side1,double side2)
        {
            this.side1=side1;
            this.side2=side2;
        }
        public void PerimeterCulk (double side1, double side2) 
        {
            perimeter = (side1 + side2)*2;
        }
        public void AreaCulk (double side1, double side2)
        {
            area = side1*side2;
        }
    }
}
