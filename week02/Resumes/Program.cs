using System;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();
    job1._company = "Microsoft";
    job1._jobTitle = "Software Engineer";
    job1._startYear = 1992;
    job1._endYear = 2003;

    Job job2 = new Job();
    job2._company = "Apple";
    job2._jobTitle = "Manager";
    job2._startYear = 2004;
    job2._endYear = 2008;

    // job1.Display();
    // job2.Display();

    Resume resume1 = new Resume();
    resume1._name = "Joshua";
    resume1._jobs.Add(job1);
    resume1._jobs.Add(job2);

    resume1.Display();
    }
}