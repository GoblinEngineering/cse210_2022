class rectangle : shape
{
    //
    private double _length;
    private double _width;

    public rectangle(string color, double side, double side2) : base(color)
    {
        _length = side;
        _width = side2;
    }

    public override double getArea()
    {
        return _length * _width;
    }
}