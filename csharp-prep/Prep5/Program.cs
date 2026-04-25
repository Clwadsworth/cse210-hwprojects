using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int squaredNumber = SquaredNumber(userNumber);
        DisplayResult(userName, squaredNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please ender your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
       Console.Write("Please ender your favorite number: ");
       int number = int.Parse(Console.ReadLine());
       return number; 
    }    
        
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        int currentYear = 2026;
        int age = currentYear - birthYear;

        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}