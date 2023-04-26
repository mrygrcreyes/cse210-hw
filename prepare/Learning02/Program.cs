using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web Developer";
        job1._company = "Apple";
        job1._startYear = 2020;
        job1._endYear = 2023;
        
        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2019;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Mary Grace";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
        // This method can be used but for shortcut you can display jobs in job.cs using (foreach)
        // job1.Display();
        // job2.Display();
    }
}