using System;

class Program
{
    static void Main(string[] args)
    {
        Random Rand = new Random();
        string answer = "";
        List<string> script = new List<string>();

        scripture scripture = new scripture();
        string scriptureString = scripture.get_script();
        script = scripture.create_list(scriptureString);
        ////
        refrence refrence = new refrence(script);
        string verses = refrence.get_verse();
        ////
        words words = new words(script);

        do
        {
            Console.Clear();
            Console.Write(refrence.get_verse() + " - ");
            foreach (string x in script)
            {
                Console.Write(x);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            bool underscore_word = true;

            foreach (string y in script)
            {
                foreach (char c in y) 
                {
                    if (c.ToString() != "_")
                    {
                        underscore_word = false;
                        break;
                    }
                }
                if (underscore_word == false)
                {
                    break;
                }
            }
            if (underscore_word == true)
                {
                    System.Environment.Exit(1);
                }

            //Console.Write();
            answer = Console.ReadLine();
            words.hide_script(5,script);
        } while (answer != "quit");

    }
}