public class SimpleGoal : Goal
{
    private bool _isComplete;
    // starting with the constructor for new goals
    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    {
        _isComplete = false;
    }
    
    // this constructor loads from exitsing saves
    public SimpleGoal(string name, string description, int point, bool IsComplete) : base(name, description, point)
    {
        _isComplete = IsComplete;
    }
    // The following pushes the override to the main goal class
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Nice job! You earned {GetPoints()} points!");
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetFieldName()},{GetDetailsString().Split('(')[1].Split(')')[0]},{GetPoints()},{IsComplete()}";
    }
    
}