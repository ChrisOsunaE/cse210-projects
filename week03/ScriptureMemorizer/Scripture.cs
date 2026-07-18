public class Scripture
{
    private List<Word> _text;
    private Reference _reference;

    public Scripture()
    {
        _text = new List<Word>();
        _reference = new Reference();

        string defaultText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        foreach (string word in defaultText.Split(' '))
        {
            Word newWord = new Word(word);
            _text.Add(newWord);
        }
    }

    public Scripture(string text, Reference reference)
    {
        _text = new List<Word>();
        _reference = reference;

        foreach (string word in text.Split(' '))
        {
            Word newWord = new Word(word);
            _text.Add(newWord);
        }
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public string DisplayText()
    {
        string displayText = "";
        foreach (Word word in _text)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public void HideRandomWords(int numberToHide)
    {
        int unhiddenWordsCount = _text.Count(word => !word.IsHidden());
        if (numberToHide > unhiddenWordsCount)
        {
            numberToHide = unhiddenWordsCount;
        }

        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_text.Count);
            if (!_text[index].IsHidden())
            {
                _text[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _text)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    
}