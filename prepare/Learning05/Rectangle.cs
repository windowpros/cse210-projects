public class Rectangle : Shape
{
    string _color;
    float _length;
    float _width;

    public Rectangle(string color, float length, float width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override float GetArea()
    {
        return _length * _width;
    }

}