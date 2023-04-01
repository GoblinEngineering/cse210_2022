using System;

class Program
{
    static void Main(string[] args)
    {
        Adress ad1 = new Adress("sus street", "sus city", "SU", "totaly Normal Country");
        //
        Lecture event1 = new Lecture("how to be normal", "teaching you how to blend in", "8AM", ad1, "5/13/2047", "Glorb from Nevodia", 20);
        //
        List<string> people = new List<string>();
        people.Add("jhon");
        people.Add("jhonny");
        people.Add("jhonathan");
        people.Add("Melvordius");
        Reception event2 = new Reception("alien 101", "how to be successfull on Earth", "10PM", ad1, "7/20/2045", people);
        //
        Outdoor event3 = new Outdoor("Flight Training", "teaching you how sucessfully land your shuttle", "3AM", ad1, "7/11/2045", "50% chance of UFO's");
        //
        List<Event> events = new List<Event>();
        events.Add(event1);
        events.Add(event2);
        events.Add(event3);
        //
        foreach (Event mission in events)
        {
            //
            mission.standard_details();
            Console.WriteLine("-----------");
            mission.full_details();
            Console.WriteLine("-----------");
            mission.short_details();
            
            Console.WriteLine("_______________________");
        }
        
    }
}