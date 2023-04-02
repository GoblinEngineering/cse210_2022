class Running : Activity
{
    private float _distance; //given

    public Running(string date, int duration, float distance) : base(date,duration)
    {
        _distance = distance;
    }

    public override void display()
    {
        base_display();
        Console.WriteLine($"Running: Distance: {_distance} Km, Speed: {calc_speed()} Kph, Pace: {calc_pace()} min per Km");
    }

    public override float calc_speed()
    {
        return (_distance / get_duration()) * 60;
    }

    public override float calc_pace()
    {
        return get_duration() / _distance;
    }

    public override float calc_distance()
    {
        return _distance;
    }
}