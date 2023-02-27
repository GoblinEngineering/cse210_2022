class breathing : activity
{
    //
    //private string _textBookSection = "";
    private string _desc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";

    public breathing(double seconds, string name) : base(seconds,name)
    {
        //
    }

    public void play()
    {
        Console.WriteLine(_desc);
        pause(4);
        Console.WriteLine("folow the prompts");
        pause(4);
        Console.WriteLine();
        do{
            //
            Console.WriteLine("breath in");
            pause(5);
            Console.WriteLine("breath out");
            pause(5);

        }while(check_duration());
        Console.WriteLine("activity complete");
    }
}