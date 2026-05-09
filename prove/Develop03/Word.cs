public class Word
{
    // Listing what Items we are hiding
    private string _text;
    private bool _isHidden;

    // This is how we will determine true and false with words that are hidden
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetRenderedText()
    {
        if (_isHidden)
        {
            // we will flesh out the underscores for the hidden text here
            return new string('_', _text.Length);

        }
        else
        {
            return _text;
        }
    }
}