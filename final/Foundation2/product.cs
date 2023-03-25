class product
{
    //
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public product( string name,  int id,  double price,  int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string get_name()
    {
        return _name;
    }

    public int get_id()
    {
        //
        return _id;
    }

    public double get_price()
    {
        //
        return _price;
    }

    public int get_quantity()
    {
        //
        return _quantity;
    }
}