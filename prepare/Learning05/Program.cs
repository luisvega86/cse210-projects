using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("blue", 3);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("green", 3, 5);
        shapes.Add(rectangle);
        Circle circle = new Circle("pink", 4);
        shapes.Add(circle);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The color of the {s} is {color}, and the area is {area}");
        }
    }
}