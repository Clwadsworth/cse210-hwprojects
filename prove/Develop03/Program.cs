using System;

// In the HideRandomWords method in the Scripture document, I was able to make sure it selects words that are still visible when it hides the words. 
// It also allows you, at every key press, to make sure that three words are taken at a time, and it overrides and overlooks the already hidden words. 
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        // Right here is where we'll build the objects for our program
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference,
        "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life");

        // We'll create a while loop here so that way our system is running until the breakpoint
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress Enter to hide the words or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
        
            scripture.HideRandomWords();
        
        }   

        // Now our new display going towards our final display when all the words are hidden
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText());
        Console.WriteLine("\nAll words are hidden. Well Done!");
    
    }
}