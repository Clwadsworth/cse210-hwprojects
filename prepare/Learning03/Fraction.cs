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

    // putting together the setters and getters
    // start with the getter for the numerator
    public int GetNumerator()
    {
        return _topNumber;
    }

    // and now the setter for the numerator
    public void SetNumerator(int numerator)
    {
        _topNumber = numerator;
    }

    // Now the getter for the denominator
    public int GetDenominator()
    {
        return _botNumber;
    }

    // finally the setter for the denominator
    public void SetDenominator(int denominator)
    {
        _botNumber = denominator;
    }

    // Now adding the string to assemble the fractions
    public string GetFractionString()
    {
        return _topNumber + "/" + _botNumber;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / _botNumber;
    }
}

