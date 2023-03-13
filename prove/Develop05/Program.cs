using System;

class Program
{
    static void Main(string[] args)
    {   
        List<goal> goals = new List<goal>();


        
        void save()//finished
        {
            string file_name;
            Console.WriteLine("enter the name of the file");
            file_name = Console.ReadLine();
            File.Delete(file_name);
            foreach(goal item in goals)
            {
                
                File.AppendAllText(file_name, ($"{item.get_name()}:{item.get_completedTasks()}:{item.get_taskDialog()}:{item.get_finishedTask}:{item.get_pointValue()}:{item.get_targetCompletions()}" + System.Environment.NewLine));

            }


        }
        // void load()
        // {
        //     string[] lines = File.ReadAllLines(file_name);

        //         foreach (string line in lines)
        //         Console.WriteLine(line);

        // }
        void create()
        {
            string option;
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            option = Console.ReadLine();
            string name;
            int completedTasks = 0;
            string taskDialog;
            bool finishedTask = false;
            int pointValue;
            int targetCompletions = 1;

            //spaceing

            Console.WriteLine("What is the name of your goal?");
            name = Console.ReadLine();
            Console.WriteLine("What is the task?");
            taskDialog = Console.ReadLine();
            Console.WriteLine("How many points is it worth when completed?");
            pointValue = Int32.Parse(Console.ReadLine());
            

            
            
            switch (option)
            {
                case "1":
                simple_goal classname1 = new simple_goal(name, taskDialog, pointValue, completedTasks, finishedTask, targetCompletions);
                goals.Add(classname1);
                break;
                //
                case "2":
                eternal_goal classname2 = new eternal_goal(name, taskDialog, pointValue, completedTasks, finishedTask, targetCompletions);
                goals.Add(classname2);
                break;
                //
                case "3":
                Console.WriteLine("How many times should the task be completed?");
                targetCompletions = Int32.Parse(Console.ReadLine());
                checklist_goal classname3 = new checklist_goal(name, taskDialog, pointValue, completedTasks, finishedTask, targetCompletions);
                goals.Add(classname3);
                break;
                
            }
        }
        void list_goals()
        {
            //
        }
        void pick()
        {
            //
        }
        void display()
        {
            //
        }

        
        //read
        //save
        //create new goal
        //list goals
        //pick a activity to mark off
        //display score
        //quit
        Console.Clear();
        string option = "";
        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Load Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. List Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            option = Console.ReadLine();

            switch (option)
            {
            case "1":
                create();
                break;
                //
            case "2":
                //load();
                break;
                //
            case "3":
                save();
                break;
                //
            case "4":
                list_goals();
                break;
                //
            case "5":
                pick();
                break;
                //
            case "6":
                display();
                break;
                //
            
            }
            Console.Clear();
        }while(option != "7");
        
    }
}