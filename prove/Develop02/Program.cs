using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            // A nice, easygoing menu to interact with
            Console.WriteLine("\nLet's start with one of these choices: ");
            Console.WriteLine("1 - Write a new entry");
            Console.WriteLine("2 - Display the journal");
            Console.WriteLine("3 - Save my record to a file");
            Console.WriteLine("4 - Load my record from a file");
            Console.WriteLine("5 - Quit");
            Console.Write("Where would you like to start? ");

            string choice = Console.ReadLine();
            // Starting with the selections
            if (choice == "1")
            {
                journal.Record();
            }
            else if (choice == "2")
            {
                journal.OpenJournal();
            }
            else if (choice == "3")
            {
                journal.InkToPaper();
            }
            else if (choice == "4")
            {
                journal.PaperToScreen();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you! and have a good rest of the day!");
                break;
            }
            else
            {
                {
                    Console.WriteLine("I don't understand, please try again.");
                }
            }
        }
    }
}