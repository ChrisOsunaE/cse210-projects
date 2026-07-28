public class Video {
  private string _title;
  private string _description;
  private string _author;
  private int _time;
  private List<Comment> _comments;
  public Video(string title, string description, string author, int time)
  {
    _title = title;
    _description = description;
    _author = author;
    _time = time;
    _comments = new List<Comment>();
  }

  public string GetTitle()
  {
    return _title;
  }

  public string GetDescription()
  {
    return _description;
  }

  public string GetAuthor()
  {
    return _author;
  }

  public int GetTime()
  {
    return _time;
  }
  
  public void addComment(Comment comment)
  {
    _comments.Add(comment);
  }

  public List<Comment> GetComments()
  {
    return _comments;
  }

  public int GetNumberOfComments()
  {
    return _comments.Count;
  }
}