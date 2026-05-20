public class Square : Shape
{
    // only need one because all sides are equal in length so no need to have another
    private float _side;

    public Square(string color, float side) : base(color)
    {
        _side = side;
    }
    // This will be overriding the virtual in shape when calling on this class
    public override float GetArea()
    {
        return _side * _side;
    }
}