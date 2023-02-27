class activity
{
    //
    private string _startTime;
    private string  _endTime;
    private string randomNum;

    public activity(double seconds, string name)
    {
        DateTime now = DateTime.Now;
        _startTime = (now.ToString("HHmmss"));
        _endTime = (now.AddSeconds(seconds).ToString("HHmmss"));
        Console.WriteLine(_startTime);
        Console.WriteLine(_endTime);
        Console.WriteLine($"Welcome to the {name} activity");

    }

    public bool check_duration()
    {
        //
        DateTime now = DateTime.Now;
        bool x;
        int time;
        int end;
        time = Int32.Parse(now.ToString("HHmmss"));
        end = Int32.Parse(_endTime);
        if (time > end) {x = false; } else{x = true; }
        return x;
    }

    public void loading(double seconds)
    {
        DateTime now = DateTime.Now;
        bool x = true;
        int time;
        int end;
        string finish = (now.AddSeconds(seconds).ToString("HHmmss"));
        time = Int32.Parse(now.ToString("HHmmss"));
        end = Int32.Parse(finish);
        do
        {
            DateTime now1 = DateTime.Now; // for super accurate time
            Console.Write("#");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("*");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("@");
            Thread.Sleep(500);
            Console.Write("\b \b");
            time = Int32.Parse(now1.ToString("HHmmss"));
            if (time > end) {x = false; } else{x = true; }
        } while(x == true);
    }

    public void pause(int num)
    {
        Thread.Sleep(num * 1000);
    }

}