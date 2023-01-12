using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        string input;
        int input_num;
        int count = 0;
        Console.WriteLine("guess a number between 1 and 100");
        do
        {
            Console.Write("what is the magic number? ");
            input = Console.ReadLine();
            input_num = int.Parse(input);
            if (input_num > number)
            {
                Console.WriteLine("guess a little lower");
            }
            else if (input_num < number)
            {
                Console.WriteLine("guess a little higher");
            }
            count++;
        } while (input_num != number);
        Console.WriteLine($"you got it! it took you {count} tries!");

    }
}