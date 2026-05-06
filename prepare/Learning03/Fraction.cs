public class Fraction
{
    // These are our private numbers to store in
    private int _topNumber;
    private int _botNumber;
// Building out the constructors to help with validating parameters

    public Fraction()
    {
        // Defaults to 1/1
        _topNumber = 1;
        _botNumber = 1;
    }

    public Fraction(int numerator)
    {
        // Defaults the denominator to x/1
        _topNumber = numerator;
        _botNumber = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        // Sets numerator and denominator number
        _topNumber = numerator;
        _botNumber = denominator;
    }

}

