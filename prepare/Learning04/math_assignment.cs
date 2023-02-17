class math_assignemnt : assignemnt
{
    //
    private string _textBookSection = "";
    private string _problems = "";

    public math_assignemnt(string name, string topic, string txt_section, string problem) : base(name,topic)
    {
        _textBookSection = txt_section;
        _problems = problem;

    }

    public string getHomeworkList()
    {
        return $"{_textBookSection} - {_problems}";
    }
}