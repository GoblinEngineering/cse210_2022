using System.Collections.Generic;
public class Resume
{
    public string _name = "";
    public List<Job> _job = new List<Job>();
        public void Display()
    {
        Console.WriteLine($"Name : {_name}");
        Console.WriteLine("Jobs :");
        for (int i = 0; i < _job.Count; i++)
        {
            _job[i].Display();
        }
    }
        
}