using System;

class Program
{
    static void Main(string[] args)
    {
        assignemnt work = new assignemnt("bob", "builder");
        Console.WriteLine(work.get_summary());

        Console.WriteLine();

        math_assignemnt math = new math_assignemnt("bob", "builder", "page 1", "1+1");
        Console.WriteLine(math.get_summary());
        Console.WriteLine(math.getHomeworkList());

        Console.WriteLine();

        writing_assignemnt paper = new writing_assignemnt("bob", "builder", "can we fix it?");
        Console.WriteLine(paper.get_summary());
        Console.WriteLine(paper.getWritingInfo());
    }
}