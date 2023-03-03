class shape
{
    //
    private string _color;

    public shape(string color)
    {
        _color = color;
    }

    public string getcolor()
    {
        return _color;
    }
    public void setcolor(string color)
    {
        _color = color;
    }

    public virtual double getArea()
    {
        return -1;
    }
}