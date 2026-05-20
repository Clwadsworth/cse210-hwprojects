public class Rectangle : Shape
{
    // They each have two different length sides so we need two
    private float _length;
    private float _width;

    public Rectangle(string color, float length, float width) : base(color)
    {
        _length = length;
        _width = width;
    }
    // This will be overriding the virtual in shape when calling on this class
    public override float GetArea()
    {
        return _length * _width;
    }
}