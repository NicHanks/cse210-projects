using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startDate = 2019;
        job1._endDate = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startDate = 2022;
        job2._endDate = 2023; 

        Resume resume1 = new Resume();
        resume1._name = "Nicoli Shaw";
        resume1._list.Add(job1);
        resume1._list.Add(job2);

        resume1.Display();
    }
}