public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will walk you through a breathing exercise that will help you relax. Clear you mind and focus on breathing in and out.")
    {    }

    // adding out full activity for breathing 
    public void Run()
    {
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        // Bool is here to switch between true and false
        bool breatheIn = true;
        while (DateTime.Now < endTime)
        {
            if (breatheIn)
            {
                Console.WriteLine("Breathe in.....");
            }
            else
            {
                Console.WriteLine("Breathe out.....");
            }

            ShowSpinner(4);
            // This changes the true/false statement from the bool
            breatheIn = !breatheIn;
        }

        DisplayEndMessage();
    }
}