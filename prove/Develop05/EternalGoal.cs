public class EternalGoal : Goal
{
    // starting with the constructor
    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {
        
    }
    // The following pushes the override to the main goal class
    public override int RecordEvent()
    {
        Console.WriteLine($"Nice job! You earned {GetPoints()} points!");
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetFieldName()},{GetDetailsString().Split('(')[1].Split(')')[0]},{GetPoints()}";
    }
}