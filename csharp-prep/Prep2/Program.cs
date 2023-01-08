using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade %? ");
        string gradeStr = Console.ReadLine();
        int grade = int.Parse(gradeStr);
        Console.WriteLine("");
        if (grade >= 90)
        {
            Console.WriteLine("you got a A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("you got a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("you got a C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("you got a D");
        }
        else
        {
            Console.WriteLine("you got a F");
        }
        
        
        if (grade >= 70)
        {
            Console.WriteLine("you got a passing grade, congratz!");
        }
        else
        {
            Console.WriteLine("Your grade isnt quite good enough, mabye spend some extra time studying");
        }

    }
}