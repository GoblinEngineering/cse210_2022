class comment
{
    private string _name;
    private string _text;

    public comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    
    public void display()
    {
        Console.WriteLine($"{_name} : '{_text}'");
    }

}