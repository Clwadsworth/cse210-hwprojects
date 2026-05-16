public class ListingActivity : Activity
{
    private List<string> _prompts;
    
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you possibly can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that have helped you this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }

    // adding out full activity for listing
    public void Run()
    {
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        ShowSpinner(5);

        int count = 0;


        while (DateTime.Now < endTime)
        {
            Console.Write("List an item: ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");

        DisplayEndMessage();
    }

}