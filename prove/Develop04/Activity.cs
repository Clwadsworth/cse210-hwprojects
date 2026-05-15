public class Activity
{
    // Hidden attributes that Activities can only access
    private string _name;
    private int _duration;
    private string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        // Requesting the Duration of the activity so the user is in charge for length
        Console.Write("How long, in seconds, do you want your session to last? ");
        _duration = int.Parse(Console.ReadLine());
    }

    // The Activities class's way of getting into the private attributes now listed
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // A generic opening message that pulls both the name and the description before every activity
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Get ready to begin...");
        Thread.Sleep(3000);
    }

    // the ending message for each activity
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Good job! You did excellent!");
        Console.WriteLine($"You did {_name} for {_duration} seconds.");
        Thread.Sleep(3000);
    }

    // Here is the spinner that we need to add for waiting times
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\"};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }
}