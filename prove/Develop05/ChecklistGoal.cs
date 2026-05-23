using System.Drawing;
using System.Formats.Tar;
using System.Runtime;

public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;
    // starting with the constructor
    public ChecklistGoal(string name, string description, int point, int target, int bonus, int amountCompleted) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
        // Starting point for determining how far into checklist we are
        _amountCompleted = amountCompleted;
    }
    // The following pushes the override to the main goal class
    public override int RecordEvent()
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
        return pointsEarned;
       
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
        // We parse the description dynamically or you can make fields protected. 
        // This extracts the description from between the parentheses.
        string description = GetDetailsString().Split('(')[1].Split(')')[0];
        return $"ChecklistGoal:{GetFieldName()},{description},{GetPoints()},{_amountCompleted},{_target},{_bonus}";
    }
}