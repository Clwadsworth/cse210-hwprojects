public class EternalGoal : Goal
{
    // starting with the constructor
    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {
        
    }
    // The following pushes the override to the main goal class
    public override void RecordEvent()
    {
        Console.WriteLine($"Nice job! You earned {GetPoints()} points!");
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
        return "";
    }
}