using System;

class Program
{
    static void Main(string[] args)
    {
        //setup
        List<string> prompt_options = new List<string>();
        prompt_options.Add("what food are you craving today?");
        prompt_options.Add("who made you laugh today?");
        prompt_options.Add("what are you excited for tomorrow?");
        prompt_options.Add("What was the best thing that happened to you today?");
        prompt_options.Add("what did you read today that was interesting?");
        Random randomGenerator = new Random();   
        //code


        Console.WriteLine("Welcome to your journal");
        int selector;

        do
        {
            Console.WriteLine("Please select one of the folowing options");
            Console.WriteLine("1) write a new entry");
            Console.WriteLine("2) view all entrys");
            Console.WriteLine("3) quit");
            Console.Write(">");
            selector = int.Parse(Console.ReadLine());

            if (selector == 1)
            {
                //randomly chooses prompt
                int number = randomGenerator.Next(0, (prompt_options.Count));
                Console.WriteLine(prompt_options[number]);
                //creates new entry
                Entry dailyEntry = new Entry();

                dailyEntry._promptAsked = prompt_options[number];
                dailyEntry._txtEntry = Console.ReadLine(); 
                Console.WriteLine("what is the file name of your journal?");
                dailyEntry._fileName = Console.ReadLine();
                dailyEntry._date = DateTime.Now.ToString("MM/dd/yyyy"); 
                dailyEntry.save();
                Console.WriteLine("entry saved.");
                //
            }
            if (selector == 2)
            {
                Console.WriteLine("what is the file name of your journal?");
                Journal journalContents = new Journal();
                journalContents._fileName = Console.ReadLine();
                journalContents.Display();
            }
            
        }while (selector != 3);
    }
}