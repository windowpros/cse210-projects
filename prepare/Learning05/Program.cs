using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        // I just need some time. I'm a little behind with other stuff. I'll get it done though. Thanks

        Shape mySquare = new Square("Red", 5.56f);
        Shape myRectangle = new Rectangle("Blue", 6.78f, 9.3f);
        Shape myCircle = new Circle("Green", 4.2f);

        List<Shape> allTheShapes = new List<Shape>();

        allTheShapes.Add(mySquare);
        allTheShapes.Add(myRectangle);
        allTheShapes.Add(myCircle);

        foreach (Shape shape in allTheShapes)
        {
            float _area = shape.GetArea();
            Console.WriteLine(_area);
        }

    }
}