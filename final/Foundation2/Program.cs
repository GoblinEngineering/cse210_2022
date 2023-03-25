using System;

class Program
{
    static void Main(string[] args)
    {
        adress adr1 = new adress("5347 West Howard Lane", "newport", "DW", "wakanda");
        adress adr2 = new adress("5201 North Cat street", "Fox", "AD", "Utopia");
        //
        customer cust1 = new customer(adr1, "Jack");
        customer cust2 = new customer(adr2, "Jill");
        //
        product prod1 = new product("seltzer water", 52, 9.99, 5);
        product prod2 = new product("honey", 99, 12.99, 1);
        //
        List<product> products1 = new List<product>();
        products1.Add(prod1);
        products1.Add(prod2);
        //
        product prod3 = new product("crackers", 78, 4.99, 3);
        product prod4 = new product("The Best Cheese In The World", 42, 42.42, 42);
        //
        List<product> products2 = new List<product>();
        products2.Add(prod3);
        products2.Add(prod4);
        //
        order ord1 = new order(products1, cust1);
        order ord2 = new order(products2, cust2);
        //
        Console.WriteLine("packing label");
        Console.WriteLine(ord1.packing_label());
        Console.WriteLine("shipping label");
        Console.WriteLine(ord1.shipping_label());
        Console.WriteLine($"Total cost: {ord1.calc_cost()}");
        //
        Console.WriteLine("----------------");
        //
        Console.WriteLine("packing label");
        Console.WriteLine(ord2.packing_label());
        Console.WriteLine("shipping label");
        Console.WriteLine(ord2.shipping_label());
        Console.WriteLine($"Total cost: {ord2.calc_cost()}");

    }
}