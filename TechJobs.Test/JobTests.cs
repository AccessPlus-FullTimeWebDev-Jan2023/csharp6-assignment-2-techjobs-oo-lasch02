﻿
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing objects
        [TestInitialize]
        public void InitializeObjects()
        {
            Job job1 = new Job();

            Job job2 = new Job();

            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }


        [TestMethod]
        public void TestSettingJobId()
        {

        }


    }




}

