class Bicycle : Activity
{
    private float _speed; //given

    public Bicycle(string date, int duration, float speed) : base(date,duration)
    {
        _speed = speed;
    }

    public override void display()
    {
        base_display();
        Console.WriteLine($"Bicycle: Distance: {calc_distance()} Km, Speed: {_speed} Kph, Pace: {calc_pace()} min per Km");
    }

    public override float calc_distance()
    {
        return (_speed / 60) * get_duration(); 
    }
    
    public override float calc_pace()
    {
        return get_duration() / calc_distance();
    }

    public override float calc_speed()
    {
        return _speed;
    }
}