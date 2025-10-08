using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes.Shape> shapes = new List<Shapes.Shape>
        {
            new Shapes.Circle("Red", 5),
            new Shapes.Square("pink", 4),
            new Shapes.Rectangle("brown", 3, 6)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}