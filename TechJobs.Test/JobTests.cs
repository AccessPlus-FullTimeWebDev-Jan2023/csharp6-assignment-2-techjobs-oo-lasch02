
using System.Data;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing objects
        //[TestInitialize]  //in order to do this, all the job objects would need to be declared above the method, then initialized inside the method. 
        //public void InitializeObjects()
        //{
            Job job1 = new Job();

            Job job2 = new Job();

            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
    //}




    [TestMethod]
        public void TestSettingJobId()
        {
            //Assert.AreNotEqual(job1.Id, job2.Id);
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job2.Id - job1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name.ToString());
            Assert.AreEqual("ACME", job3.EmployerName.ToString());
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job3.JobType.ToString());
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.AreEqual(job1.Equals(job2), false);
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual(Environment.NewLine + "ID: " + job3.Id +
                Environment.NewLine + "Name: Product tester" + 
                Environment.NewLine + "Employer: ACME" + 
                Environment.NewLine + "Location: Desert" + 
                Environment.NewLine + "Position Type: Quality control" + 
                Environment.NewLine + "Core Competency: Persistence" + 
                Environment.NewLine, job3.ToString());
        }

        //If a field is empty, the method should add, “Data not available” after the label.
        //(expected, actual)
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            //Assert.AreEqual("Data not available", job1.ToString());
            //Assert.AreEqual(Environment.NewLine + "ID: " + job3.Id +
            //    Environment.NewLine + "Name: Data not available" +
            //    Environment.NewLine + "Employer: Data not available" +
            //    Environment.NewLine + "Location: Data not available" +
            //    Environment.NewLine + "Position Type: Data not available" +
            //    Environment.NewLine + "Core Competency: Data not available" +
            //    Environment.NewLine, job1.ToString());

            job3.Name = "";

            Assert.AreEqual(Environment.NewLine + "ID: " + job3.Id +
            Environment.NewLine + "Name: Data not available" +
            Environment.NewLine + "Employer: ACME" +
            Environment.NewLine + "Location: Desert" +
            Environment.NewLine + "Position Type: Quality control" +
            Environment.NewLine + "Core Competency: Persistence" +
            Environment.NewLine, job3.ToString());

            //            Assert.AreEqual(Environment.NewLine + "Core Competency:  " +
            //Environment.NewLine, "Core Competency: Data not available");
        }

    }




}

