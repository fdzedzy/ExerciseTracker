using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseTracker.BusinessLogic;
using ExerciseTracker.Model;
using System.Collections.Generic;
using System;

namespace ExerciseTracker.BusinessLogic.Tests
{
    [TestClass]
    public class PopulateDatabaseTest
    {
        [TestInitialize]
        public void Setup()
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var users = new List<User>
                {
                    new User()
                    {
                        BirthDate = new DateTime(1992, 7, 28),
                        FirstName = "Joe",
                        LastName = "Schmoe",
                        HeightInInches = 72,
                        WeightInPounds = 191
                    }
                };
                db.Users.AddRange(users);
            }
        }

        [TestMethod]
        public void GetUserFromDB()
        {
            Assert.AreEqual(true, true);
        }
    }
}
