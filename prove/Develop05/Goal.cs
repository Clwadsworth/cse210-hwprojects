public abstract class Goal
{
    // Listing our private for all the of classes
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int point)
    {
        _shortName = name;
        _description = description;
        _points = point;
    }

    // This is where our polymorphism starts
    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkbox = " ";
        // This checks the status of the checklist goal
        if (IsComplete())
        {
            checkbox = "X";
        }

        return $"[{checkbox}] {_shortName} ({_description})";
    }
    // This lets the child classes know that a private item is there even if they cannot access it
    public string GetFieldName()
    {
        return _shortName;
    }

    public abstract string GetStringRepresentation();

    // Adding code to get the points for child classes
    public int GetPoints()
    {
        return _points;
    }

}