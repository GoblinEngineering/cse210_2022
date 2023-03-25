class adress
{
    //
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;

    public adress(string streetAdress, string city, string state, string country)
    {
        _streetAdress = streetAdress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool is_usa()
    {
        if (_country == "usa")
        {
            return true;
        }
        return false;
    }
    
    public string return_adress()
    {
        return $"{_streetAdress} {_city} {_state} {_country}";
    }


}