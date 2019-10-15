using System;

namespace AbstractMethod
{
    public abstract class Shape
    {
        public double Width, Height, Radius;
        public const float pi = 3.14f;
        public abstract double GetArea();
        
    }
    public class Rectangle : Shape
    {
        public Rectangle(double Width, double Height)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public override double GetArea()
        {
            return Height * Width;
        }
    }
    public class Circle : Shape
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Radius * pi;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(1.2,1.1);
            Circle c = new Circle(2.1);
            Console.WriteLine(r.GetArea());
            Console.WriteLine(c.GetArea());
            Console.WriteLine("Hello World!");
        }
    }
}
