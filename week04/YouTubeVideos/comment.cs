public class Comment
{
    private string _text;
    private string _author;
    private DateTime _timestamp;

    public Comment(string text, string author, DateTime timestamp)
    {
        _text = text;
        _author = author;
        _timestamp = timestamp;
    }

    public string GetText()
    {
        return _text;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public DateTime GetTimestamp()
    {   
        return _timestamp;
    }
    
}