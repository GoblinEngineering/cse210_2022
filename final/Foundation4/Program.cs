using System;

class Program
{
    static void Main(string[] args)
    {
        Running day1 = new Running("10/2/2020", 60, 2);
        Bicycle day2 = new Bicycle("10/3/2020", 120, 3);
        Swim day3 = new Swim("10/4/2020", 30, 5);

        List<Activity> list = new List<Activity>();
        list.Add(day1);
        list.Add(day2);
        list.Add(day3);

        foreach (Activity day in list)
        {
            //
            day.display();
        }

    }
}