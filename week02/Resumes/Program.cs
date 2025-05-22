using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Company A";
        job1._title = "Software Engineer";
        job1._startYear = "2020";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._company = "Company B";
        job2._title = "Senior Software Engineer";
        job2._startYear = "2022";
        job2._endYear = "Present";


        job1.Display();
        job2.Display();

        Resume resume = new Resume();
        resume._name = "John Doe";
        resume.jobs.Add(job1);
        resume.jobs.Add(job2);
        resume.Display();

    }
}