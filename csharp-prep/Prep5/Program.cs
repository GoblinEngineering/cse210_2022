using System;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromtUserName()
        {
            Console.Write("Please enter yoour name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter yoour favorite number: ");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            return num;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(int num, string name)
        {
            Console.Write($"{name}, the square of your number is {num}");
        }

        DisplayWelcome();
        string name = PromtUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(square, name);

    }
}