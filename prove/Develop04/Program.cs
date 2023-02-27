using System;

class Program
{
    static void Main(string[] args)
    {   
        double num = 2;
        //activity nothin = new activity(num, "sus");
        //Thread.Sleep(3000);
        //Console.Write(nothin.check_duration());
        //nothin.loading(10);
        breathing breath = new breathing(5,"breathing activty");
        breath.play();



    }
}