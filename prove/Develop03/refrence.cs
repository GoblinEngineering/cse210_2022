class refrence
{
    private string verses = "Luke 20:13";
    private List<string> _scriptureText = new List<string>();

    public refrence(string verses_input, List<string> scripture_input)
    {
        verses = verses_input;
        _scriptureText = scripture_input;

    }

    public refrence(List<string> scripture_input)
    {
        _scriptureText = scripture_input;
    }

    public void set_verse(string text)
    {
        verses = text;
    }

    public string get_verse()
    {
        return verses;
    }

        public void set_script(List<string> text)
    {
        _scriptureText = text;
    }

    public List<string> get_script()
    {
        return _scriptureText;
    }
}