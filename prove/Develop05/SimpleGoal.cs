public class SimpleGoal : Goal
{
    private bool _isComplete;
    // starting with the constructor
    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    {
        _isComplete = false;
    }
    // The following pushes the override to the main goal class
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Nice job! You earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetStringRepresentation()
    {
        return "";
    }
}