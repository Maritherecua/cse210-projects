using System;



partial class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Tech Corp";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._companyName = "Innovatech";
        job2._startYear = 2023;
        job2._endYear = 2024;



        //DisplayJobInfo(job1);
        //DisplayJobInfo(job2);

        Resume myResume = new Resume();
        myResume._name = "Vince Walker";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();

    }
    
    // Define the Resume class
    //public class Resume
    //{
        //public string _name;
        //public List<Job> _jobs = new List<Job>();
    
        //public void Display()
        //{
            //Console.WriteLine($"Name: {_name}");
            //Console.WriteLine("Jobs:");
            //foreach (var job in _jobs)
            //{
                //job.Display();
            //}
        //}
   // }
    
    // Define the Job class
    //public class Job
    //{
        //public string _jobTitle;
        //public string _companyName;
        //public int _startYear;
        //public int _endYear;
    
        //public void Display()
        //{
            //Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
        //}
    //}

    //static void DisplayJobInfo(Job job)
    //{
        //job.Display();
    //}
}