//class job keeps track of the company, job title,start year and end year
//Displays the job information in the format "Job Title (Company Name) [Start Year - End Year]"
//Example: Software Engineer (Tech Corp) [2020 - 2023]
using System;

    public class Job
{
    public string _companyName;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_companyName}) [{_startYear} - {_endYear}]");
        }
}   