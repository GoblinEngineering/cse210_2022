public class Entry
{

    public string _promptAsked = "";
    public string _fileName = "";
    public string _date = "";
    public string _txtEntry = "";

    public void save()
    {
        string Space = System.Environment.NewLine;
        File.AppendAllText(_fileName, ($"Prompt asked : {_promptAsked}" + Space + $"Answer : {_txtEntry} - {_date}" + Space + Space ));
    }
        
}