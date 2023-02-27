class reflection : activity
{
    //
    private string _desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private List<string> _prompts;
    
    
    public reflection(double seconds, string name) : base(seconds,name)
    {
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");
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
