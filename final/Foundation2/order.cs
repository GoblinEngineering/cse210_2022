class order
{
    //
    private List<product> _items;
    private customer _customer;

    public order(List<product> items, customer customer)
    {
        _items = items;
        _customer = customer;

    }

    public string packing_label()
    {
        string label = "";
        foreach(product item in _items)
        {
            label = label + $"{item.get_id()}:{item.get_name()} |{Environment.NewLine}";
        }
        return label;
    }

    public string shipping_label()
    {
        return $"name: {_customer.get_name()} | adress: {(_customer.get_adress()).return_adress()}";
    }

    public double calc_cost()
    {
        double total = 0;
        foreach(product item in _items)
        {
            total = total + (item.get_price() * item.get_quantity());
        }
        if ((_customer.get_adress()).is_usa())
        {
            return total + 5;
        }
        return total + 35;
    }

    
}