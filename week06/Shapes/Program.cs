using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square(3,"Red");
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle(4, 5, "Blue");
        shapes.Add(shape2);

        Circle shape3 = new Circle(6, "Green");
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}