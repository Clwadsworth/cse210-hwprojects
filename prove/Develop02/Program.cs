using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1 - Write a new entry");
            Console.WriteLine("2 - Display the journal");
            Console.WriteLine("3 - Save the journal to a file");
            Console.WriteLine("4 - Load the journal from a file");
            Console.WriteLine("5 - Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                journal.SaveToFile();
            }
            else if (choice == "4")
            {
                journal.LoadFromFile();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
                break;
            }
            else
            {
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }
    }
}