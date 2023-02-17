class writing_assignemnt : assignemnt
{
    //
    private string _title = "";

    public writing_assignemnt(string name, string topic, string title) : base(name,topic)
    {
        _title = title;
    }

    public string getWritingInfo()
    {
        return $"{_title}";
    }
}