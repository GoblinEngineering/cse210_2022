using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac = new Fraction(1,2);
        int top_num;
        int bot_num;
        void tester(int top, int bot)
        {
            frac.SetTop(top);
            frac.SetBottom(bot);
            Console.WriteLine(frac.GetTop());
            Console.WriteLine(frac.GetBottom());
            Console.WriteLine(frac.GetFractionString());
            Console.WriteLine(frac.GetDecimalValue());
            
        }
        tester(1,1);
        tester(5,1);
        tester(3,4);
        tester(1,3);
        Console.Write("top num : ");
        top_num = int.Parse(Console.ReadLine());
        Console.Write("bot num : ");
        bot_num = int.Parse(Console.ReadLine());
        tester(top_num,bot_num);
    }
}