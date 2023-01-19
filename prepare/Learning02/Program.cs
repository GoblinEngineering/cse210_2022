using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Poblocki";
        job1._jobTitle = "Civil Engineer";
        job1._startYear = 2010;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "yesco";
        job2._jobTitle = "Civil Engineer";
        job2._startYear = 2000;
        job2._endYear = 2010;


        Resume resume1 = new Resume();
        resume1._name = "Wade Carter";
        resume1._job.Add(job1);
        resume1._job.Add(job2);
        resume1.Display();
    }
}