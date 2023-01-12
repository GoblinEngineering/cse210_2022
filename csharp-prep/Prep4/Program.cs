using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    
    {
        

        List<int> numbers = new List<int>();

        string input;
        int input_num;
        Console.WriteLine("enter a series of numbers, enter zero when you are finished. ");
        do
        {
            input = Console.ReadLine();
            input_num = int.Parse(input);
            if (input_num != 0)
            {
                numbers.Add(input_num);
            }
        } while (input_num != 0);

        int max_num = -9999999;
        int sum = 0;
        int running_count = 0;
        foreach (int num in numbers)
        {
            if (num > max_num)
            {
                max_num = num;
            }
            sum = sum+num;
            running_count++;
        }
        float avg = sum/running_count;


        Console.WriteLine($"the sum is {sum}");
        Console.WriteLine($"the average is {avg}");
        Console.WriteLine($"the largest number is {max_num}");
    }
}