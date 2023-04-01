class Outdoor : Event
{
    //
    private string _forcast;

    private string _eventType = "outdoor";

    public Outdoor(string eventTitle, string description, string time, Adress adress, string date, string forcast) : base(eventTitle, description, time, adress, date)
    {
        _forcast = forcast;
    }

    public override void full_details()
    {
        standard_details();
        Console.WriteLine($"forcast : {_forcast}");
    }

    public override void short_details()
    {
        Console.WriteLine($"event type : {_eventType}");
        shorter_details();
    }
}