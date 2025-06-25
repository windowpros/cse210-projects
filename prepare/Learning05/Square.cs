public class Square : Shape
{
    string _color;
    float _length;

    public Square(string color, float length) : base (color)
    {
        _length = length;
    }
    public override float GetArea()
    {
        return _length * _length;
    }

}