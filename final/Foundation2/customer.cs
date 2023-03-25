class customer
{
    //
    private string _name;
    private adress _adress;

    public customer(adress adress, string name)
    {
        _adress = adress;
        _name = name;
    }

    public string get_name()
    {
        //
        return _name;
    }

    public adress get_adress()
    {
        return _adress;
    }
}