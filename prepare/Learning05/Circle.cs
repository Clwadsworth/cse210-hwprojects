public class Circle : Shape
{
    // Only need radius since pi is built in
    private float _radius;

    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }
    // This is giving permission to the "child" class to override it
    public override float GetArea()
    {
        return (float)(Math.PI * _radius * _radius);
    }
}