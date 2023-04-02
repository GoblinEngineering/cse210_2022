class Swim : Activity
{
    private float _laps; //given

    public Swim(string date, int duration, float laps) : base(date,duration)
    {
        _laps = laps;
    }

    public override void display()
    {
        base_display();
        Console.WriteLine($"Swim: Distance: {calc_distance()} Km, Speed: {calc_speed()} Kph, Pace: {calc_pace()} min per lap");
    }

    public override float calc_distance()
    {
        return _laps * 50 / 1000; 
    }

    public override float calc_speed()
    {
        return (calc_distance() / get_duration()) * 60;
    }

    public override float calc_pace()
    {
        return get_duration() / _laps;
    }

    
    //
}