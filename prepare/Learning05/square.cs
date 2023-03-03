class square : shape
{
    //
    private double _side;

    public square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double getArea()
    {
        return _side * _side;
    }
}
