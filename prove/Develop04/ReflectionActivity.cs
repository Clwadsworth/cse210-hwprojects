public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. With this, you will recognice power and see aspects in your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time that you stood up for someone else that needed it.",
            "Think of a time when you did something that felt really difficult.",
            "Think of a time when you helped someone out in need.",
            "Think of a time when you did something that did not make you think of yourself.",
        };
        
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than the other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }

    // adding out full activity for reflection
    public void Run()
    {
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        // This is here to prompt the question that goes along with the prompt
        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];

            Console.WriteLine(question);
            ShowSpinner(5);
        }


        DisplayEndMessage();
    }
}