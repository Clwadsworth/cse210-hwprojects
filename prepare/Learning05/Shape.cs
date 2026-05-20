public class Shape
{
    private string _color;
    // Assigning a color to a particular shape to allow multiple shapes to be called from one list
    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    // This is giving permission to the "child" class to override it
    public virtual float GetArea()
    {
        return 0;
    }
}