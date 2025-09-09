// Define the Resume class
    public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();
    
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            // Display each job's information
            foreach (var job in _jobs)

        {   //calls the display method from the job class
            job.Display();
        }
        }
    }