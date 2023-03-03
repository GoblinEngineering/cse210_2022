class circle : shape
{
    //
    private double _radius;

    public circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double getArea()
    {
        return _radius * Math.PI;
    }
}