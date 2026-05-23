using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    // Starts our menu for the user
    public void Start()
    {
        // Creating the while loop that will keep track of the menu activity
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            // Telling the system what to do for each selection
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": quit = true; break;
                default: Console.WriteLine("Invalid choice. Please try again."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        // Creating the "scoreboard"
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoalNames()
    {
        // calling the list that was made in RecordEvent
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetFieldName()}");
        }
    }

    public void ListGoalDetails()
    {
        // prints out what the goals we have are
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        // giving the menu to create the users goal
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which tupe of goals would you like to create? ");
        string type = Console.ReadLine();

        // step instructions for creating the goal for the lists
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        // the if statement on where to go with each selection
        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            // Adding the input for the bonus feature that comes with the checklist goal
            Console.Write("How many times does this goal need to recorded to be accomplished for this bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus amount for completign this task? ");

            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus, 0));
        }
    }

    public void RecordEvent()
    {
        // Returns the list of goals the user created to allow them to pick
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetFieldName()}");
        }

        // retreives the index number
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        // initiates the action
        int pointsEarned = _goals[index].RecordEvent();

        // updates the score that the goal has listed to total points pool
        _score += pointsEarned;
    }

    public void SaveGoals()
    {
        // creates a save path to store the goals on in a file
        Console.Write("What is the filename to store the goal? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // save the score and goal
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        // pull from the save file the goal that was saved
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        // Fail safe for not finding file
        if (!System.IO.File.Exists(filename))
        {
            Console.WriteLine("File not found");
            return;
        }

        // loads the saved score
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line)) continue;
            
            // this is needed to split the parts up within the simple goal
            string[] parts = line.Split(':');
            string goalType = parts[0];
            string[] goalData = parts[1].Split(',');

            string name = goalData[0];
            string description = goalData[1];
            int points = int.Parse(goalData[2]);

            if (goalType == "SimpleGoal")
            {
                bool IsComplete = bool.Parse(goalData[3]);
                SimpleGoal simple = new SimpleGoal(name, description, points, IsComplete);

                if (IsComplete)
                {
                    simple.RecordEvent();
                }
                _goals.Add(simple);
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                int amountCompleted = int.Parse(goalData[3]);
                int target = int.Parse(goalData[4]);
                int bonus = int.Parse(goalData[5]);

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
    _goals.Add(checklist);

                // this loop checks to see the progress of the checklist and if it is completed
                for (int j = 0; j < amountCompleted; j++)
                {
                    // here we are just getting the counter for the completed list
                    checklist.GetDetailsString();
                }
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
    
}