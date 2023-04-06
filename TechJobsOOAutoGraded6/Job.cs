using System;
using System.ComponentModel.Design;

namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public int Id { get; }
            private static int nextId = 1;
            public string? Name { get; set; }
            public Employer? EmployerName { get; set; }
            public Location? EmployerLocation { get; set; }
            public PositionType? JobType { get; set; }
            public CoreCompetency? JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;

        }
            public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) :this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation; 
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        
        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.

        public override string ToString()
        {
             if (Name == null)
            {
                Name = "Data not available";
            }
             if (EmployerName.Value == null)
            {
                EmployerName.Value = "Data not available";
            }
             if (EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not available";
            }
             if (JobType.Value == null)
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == null)
            {
                JobCoreCompetency.Value = "Data not available";
            }
            
            string jobString = $@"{Environment.NewLine}ID: {Id}
Name: {Name}
Employer: {EmployerName.Value}
Location: {EmployerLocation.Value}
Position Type: {JobType.Value}
Core Competency: {JobCoreCompetency.Value}{Environment.NewLine}";

            return jobString;
        }
    } 
}
