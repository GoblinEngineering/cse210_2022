using System;

class Program
{
    static void Main(string[] args)
    {
        List<shape> shapes = new List<shape>();
        shapes.Add(new square("Blue",5));
        shapes.Add(new rectangle("Red",5, 7));
        shapes.Add(new circle("Yellow",5));

        foreach (shape thing in shapes)
        {
            double area = thing.getArea();
            Console.Write(thing.getcolor() + " ");
            Console.WriteLine(area + " -Area");
        }
    }
}