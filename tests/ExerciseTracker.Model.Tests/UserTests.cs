using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseTracker.Model;
using System;

namespace ExerciseTracker.Model.Tests
{
    [TestClass]
    public class UserTests
    {
        private User _testUser;

        [TestInitialize]
        public void Setup()
        {
            _testUser = new User()
            {
                BirthDate = new DateTime(1987, 4, 19),
                FirstName = "Joe",
                LastName = "Schmoe",
                HeightInInches = 75,
                WeightInPounds = 180
            };
        }

        [TestMethod]
        public void TestUserObject()
        {
            Assert.AreEqual("Joe", _testUser.FirstName);
        }

        [TestMethod]
        public void TestUserAge()
        {
            int days = (DateTime.Today - _testUser.BirthDate).Days;
            double ageT = days / 365;

            Assert.AreEqual(ageT, _testUser.Age());
        }
    }
}
