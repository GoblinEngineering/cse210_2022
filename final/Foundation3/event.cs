class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Adress _adress;

    private string _eventType = "standard";

    public void standard_details()
    {
        Console.WriteLine($"event: {_eventTitle}");
        Console.WriteLine($"description : {_description}");
        Console.WriteLine($"date : {_date}");
        Console.WriteLine($"time : {_time}");
        Console.WriteLine($"adress : {_adress.return_adress()}");
    }

    public virtual void full_details()
    {
        standard_details();
    }

    public virtual void short_details()
    {
        Console.WriteLine($"event type : {_eventType}");
        shorter_details();
    }

    public void shorter_details()
    {
        //
        Console.WriteLine($"event: {_eventTitle}");
        Console.WriteLine($"date : {_date}");
    }

    public Event(string eventTitle, string description, string time, Adress adress, string date)
    {
        _eventTitle = eventTitle;
        _description = description;
        _time = time;
        _adress = adress;
        _date = date;
    }


}