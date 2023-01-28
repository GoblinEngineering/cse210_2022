public class Journal
{
    public string _fileName = "";
    public void Display()
    {
        //
        string text = File.ReadAllText(_fileName);  
        Console.WriteLine(text);  
    }
}