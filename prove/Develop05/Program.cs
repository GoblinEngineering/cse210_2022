using System;

class Program
{
    static void Main(string[] args)
    {   
        List<goal> goals = new List<goal>();


        
        void save()
        {
            string file_name;
            Console.WriteLine("enter the name of the file");
            file_name = Console.ReadLine();
            foreach(goal item in goals)
            {
                //
                //write
                //
                
            }


        }
        void load()
        {
            //
        }
        void create()
        {
            //
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
                load();
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
        }while(option != "7");
        
    }
}