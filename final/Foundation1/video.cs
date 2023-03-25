class video
{
    private List<comment> _comments;
    private string _title;
    private string _author;
    private int _length;

    public video(List<comment> comments, string title, string author, int length)
    {
        _comments = comments;
        _title = title;
        _author = author;
        _length = length;
    }

    public int get_comment_count()
    {
        return _comments.Count;
    }

    public void display()
    {
        Console.WriteLine($"'{_title}' by {_author} - {_length} seconds");
        Console.WriteLine("-------");
        foreach(comment item in _comments)
        {
            item.display();
        }
        Console.WriteLine("-------");
        Console.WriteLine("");
    }
}