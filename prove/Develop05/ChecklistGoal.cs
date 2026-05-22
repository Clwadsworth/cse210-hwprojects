using System.Formats.Tar;
using System.Runtime;

public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;
    // starting with the constructor
    public ChecklistGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
        // Starting point for determining how far into checklist we are
        _amountCompleted = 0;
    }
    // The following pushes the override to the main goal class
    public override void RecordEvent()
    {
        // this allows the increment to increase to reach the goal
        _amountCompleted++;
        // starting of the base points
        int pointsEarned = GetPoints();
        // checks if we hit the target or not
        if (_amountCompleted >= _target)
        {
            pointsEarned += _bonus;
        }
        Console.WriteLine($"Nice job! You earned {pointsEarned} points!");
       
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}