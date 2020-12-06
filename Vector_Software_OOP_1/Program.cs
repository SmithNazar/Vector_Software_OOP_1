using System;
using System.Collections.Generic;
using System.Linq;

namespace Vector_Software_OOP_1
{
    public abstract class Shape 
    {
        public abstract double Area();
    }

    public class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side; 
        }
        public override double Area()
        {
            return side * side;
        }
    }
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }
    public class Triangle : Shape
    {
        private double t_base;
        private double height;

        public Triangle(double t_base, double height)
        {
            this.t_base = t_base;
            this.height = height;
        }

        public override double Area()
        {
            return (t_base * height)/2;
        }
    }
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius) 
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return radius * System.Math.PI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            static void Area() 
            { 
                List<Shape> Areas = new List<Shape>();
                Areas.Add(new Square(4));
                Areas.Add(new Rectangle(9, 4));
                Areas.Add(new Triangle(6, 8));
                Areas.Add(new Circle(5));
                Areas.Add(new Square(8));
                Areas.Add(new Triangle(45, 8));

                List<Shape> SortedList = Areas.OrderBy(o => o.Area()).ToList();

                foreach (var item in SortedList)
                {
                    Console.WriteLine(item.Area());
                }
            }
            Area();
        }
    }
}
