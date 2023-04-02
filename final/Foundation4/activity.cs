abstract class Activity
{
    //
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        //
        _date = date;
        _duration = duration;
    }

    public abstract void display();

    public void base_display()
    {
        Console.Write($"{_date} ({_duration} Mins) ");
    }

    public float get_duration()
    {
        return _duration;
    }

    public abstract float calc_speed();
    public abstract float calc_pace();
    public abstract float calc_distance();
    
}
