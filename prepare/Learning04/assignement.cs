class assignemnt
{
    //
    private string _studentName = "";
    private string _topic = "";

    public assignemnt()
    {
        //
    }
    public assignemnt( string name, string topic)
    {
        _topic = topic;
        _studentName = name;
    }
    public string get_summary()
    {
        return $"{_studentName} - {_topic}";
    }
}