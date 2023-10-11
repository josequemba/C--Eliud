using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        Square square = new Square (5, "Blue");

        Rectangle rectangle = new Rectangle (5, 3, "Yellow");

        Circle circle = new Circle (5, "Brown");


        List<Shape> shapes = new List<Shape> ();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shap in shapes)
        {
            Console.WriteLine($"The {shap.GetColor ()} has an area of: {shap.GetArea ()}");
        }
    }
}