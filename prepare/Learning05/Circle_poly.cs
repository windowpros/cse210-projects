public class Circle : Shape
{
    string _color;
    float _radius;

    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }
    public override float GetArea()
    {
        return _radius * _radius * (float)Math.PI;
    }
    

}