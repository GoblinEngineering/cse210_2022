class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    private string _eventType = "lecture";

    public Lecture(string eventTitle, string description, string time, Adress adress, string date, string speaker, int capacity) : base(eventTitle, description, time, adress, date)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void full_details()
    {
        standard_details();
        Console.WriteLine($"speaker : {_speaker}");
        Console.WriteLine($"capacity : {_capacity}");
    }

    public override void short_details()
    {
        Console.WriteLine($"event type : {_eventType}");
        shorter_details();
    }
}