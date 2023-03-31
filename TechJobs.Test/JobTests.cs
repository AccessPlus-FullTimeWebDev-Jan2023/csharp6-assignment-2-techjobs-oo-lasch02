
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing objects
        //[TestInitialize]
        //public void InitializeObjects()
        //{
            Job job1 = new Job();

            Job job2 = new Job();

            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //}


//Each Job object should contain a unique ID number, and these should also be sequential integers.  In JobTests, define a test called TestSettingJobId.
//  Using job1 and job2, compare two empty constructor Job objects. Use Assert.AreEqual, Assert.IsTrue, or Assert.IsFalse to test that the ID values for the two objects are NOT the same and differ by 1.
//How could you compare Id numbers?
//How could you test the incrementing amount?
//Run the test to verify that your Job() constructor correctly assigns ID numbers.
//If the test doesn’t pass, what should be your first thought?//
//“I need to fix the unit test.”
//“I need to fix my Job() constructor code.”

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job1.Id, job2.Id);
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job1.Id == 1 && job2.Id == 2);
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
            Assert.AreEqual(job1.Id == job2.Id, false);
        }


    }




}

