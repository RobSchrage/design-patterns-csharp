using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrototypePattern.RealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.ClientCode();
        }
    }

    class Client
    {
        public void ClientCode()
        {
            var shapes = new List<Shape>();

            var circle = new Circle()
            {
                X = 10,
                Y = 20,
                Color = "Red",
                Radius = 100
            };

            var circleClone = circle.Clone();


            shapes.Add(circle);
        }

    }

    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        protected Shape() { }

        protected Shape(Shape prototypeShape)
        {
            if (prototypeShape != null)
            {
                this.X = prototypeShape.X;
                this.Y = prototypeShape.Y;
                this.Color = prototypeShape.Color;
            }
        }

        public abstract Shape Clone();
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Rectangle source) : base(source)
        {
            if (source != null)
            {
                this.Width = source.Width;
                this.Height = source.Height;
            }
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle() {
        }

        public Circle(Circle source) : base(source)
        {
            if (source != null)
            {
                this.Radius = source.Radius;
            }
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }

}
