using System.Globalization;
using System.IO.Compression;

class Cylinder
{
    private Circle _circle;

    private double _height;

    public void SetCircle(Circle circle)
    {
        _circle = circle;
    }

    public Cylinder()
    {
        _height = 0;
        _circle = null;
    }

    public Cylinder(Circle circle)
    {
        _circle = circle;
        _height = 0;
    }

    public Cylinder(double height, Circle circle)
    {
        _height = height;
        _circle = circle;
    }

    public Cylinder(double height)
    {
        _height = height;
        _circle = null;
    }

    public Cylinder(double height, double radius)
    {
        _height = height;
        _circle = new Circle(radius);
    }

    public void SetHeight(double height)
    {
        _height = height;
    }

    public double GetVolume()
    {
        double radius = _circle.GetRadius();
        return _circle.GetArea() * _height;
        // return Math.PI * radius * radius * _height;
    }
}