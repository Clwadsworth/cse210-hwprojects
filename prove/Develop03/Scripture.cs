using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // From here, the constructor takes the reference object and the full scripture and puts it into one string
    // then, it will split the string into individual word objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Here is our randomizer that will hide the words for the text
    public void HideRandomWords()
    {
        Random random = new Random();
        
        // Writing code here that will grab words that aren't hidden and make it so that there's a minimum amount of words that are hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0) return;
        int wordsToHide = Math.Min(3, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            // I added this little bit of line to make sure it's picking words that haven't been removed yet
        }
    }

    // Here, we will write the display to show the reference and all the words, whether it's hidden or visible
    public string GetRenderedText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetRenderedText()));
        return $"{_reference.GetDisplayText()} {wordsText}";
    }

    // Here is our identifier if all the words have been completely hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}