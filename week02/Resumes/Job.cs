using System;
    public class Job
    {
        public int _startYear;
        public int _endYear;
        public string _jobTitle;
        public string _companyName;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} at {_companyName} from {_startYear} to {_endYear}") ;
        }
    }



    