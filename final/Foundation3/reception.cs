class Reception : Event
{
    //
    private List<string> _atendee;

    private string _eventType = "reception";

    public Reception(string eventTitle, string description, string time, Adress adress, string date, List<string> atendee) : base(eventTitle, description, time, adress, date)
    {
        _atendee = atendee;
    }

    public override void full_details()
    {
        standard_details();
        Console.WriteLine($"atendee's --------");
        foreach (string person in _atendee)
        {
            Console.WriteLine($"name : {person}");
        }
        
    }

    public override void short_details()
    {
        Console.WriteLine($"event type : {_eventType}");
        shorter_details();
    }
}