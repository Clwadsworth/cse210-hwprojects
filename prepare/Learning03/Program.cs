using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        // Updateing f1 - f3 and adding f4 into the mix
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(7);
        Fraction f3 = new Fraction(2, 3);
        Fraction f4 = new Fraction(6, 7);

        // Testing numbers to make sure numbers are outputting
        // f3.SetNumerator(7);
        // f3.SetDenominator(6);
        // Console.WriteLine(f3.GetNumerator());
        // Console.WriteLine(f3.GetDenominator());

        // Adding console displays
        Console.WriteLine(f1.GetFractionString());  
        Console.WriteLine(f1.GetDecimalValue().ToString("F2"));    
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue().ToString("F2"));
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue().ToString("F2"));
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue().ToString("F2"));

        // Creating a randomize loop for 10 different fractions
        Fraction f = new Fraction();
        Random random = new Random();

        // for loop with parameters that will give us 20 results
        for (int i = 0; i < 20; i++)
        {
            int numerator = random.Next(1, 10);
            int denominator = random.Next(1, 10);

            f.SetNumerator(numerator);
            f.SetDenominator(denominator);

            // Final Results in Which fraction, fraction string, and decimal   
            Console.WriteLine($"Fraction {i + 1}: string: {f.GetFractionString()} Number: {f.GetDecimalValue():F2}");
        }

    }
}