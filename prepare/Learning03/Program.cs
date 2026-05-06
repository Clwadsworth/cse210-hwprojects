using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(4);
        Fraction f3 = new Fraction(8, 9);

        f3.SetNumerator(7);
        f3.SetDenominator(6);
        Console.WriteLine(f3.GetNumerator());
        Console.WriteLine(f3.GetDenominator());
    }
}