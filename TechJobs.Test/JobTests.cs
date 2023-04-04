using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Xml.Linq;
using TechJobsOOAutoGraded6;
namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //Testing Objects
        //initalize your testing objects here

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.AreEqual(job1.Id + 1, job2.Id);
            //compare two empty constructor job objects
        }


        //Test 4
        [TestMethod]
        public void TestJobsForEquality()
        {
            bool testEquals = job1.Equals(job1);
            Assert.AreEqual(true, testEquals);
            //Assert.AreEqual(testEquals, true);
        }

        //Test 4
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Assert.IsTrue(job3.Name == "Product tester");
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.AreEqual("Desert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);
        }

        //Test 5
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }

        public void TestToStringContainsCorrectLabelsAndData()
        {
            string expectedString = $@"{Environment.NewLine}ID: {job3.Id}
Name: {job3.Name}
Employer: {job3.EmployerName.Value}
Location: {job3.EmployerLocation.Value}
Position Type: {job3.JobType.Value}
Core Competency: {job3.JobCoreCompetency.Value}{Environment.NewLine}";
            string actualString = job3.ToString();
            Assert.AreEqual(expectedString, actualString);
        }
        public void TestToStringHandlesEmptyField()
        {
            //Is this meant to be a try catch. Meaning try the string interpolation with an instance of an object that is missing a field 
           Job job5 = new Job("Product tester", new Employer("ACME"), new Location(), new PositionType("Quality control"), new CoreCompetency("Persistence")); 
            
           
            

            string expectedString = $@"
            {Environment.NewLine}
               ID: {job5.Id}
               Name: {job5.Name}
               Employer: {job5.EmployerName}
               Location: ""Data not available""
               Position Type: 
               Core Competency: 
            {Environment.NewLine}
            ";


            string actualString = job1.ToString();
            Assert.AreEqual(expectedString, actualString);
        }

    }
}

