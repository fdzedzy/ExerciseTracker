using System;
using Microsoft.EntityFrameworkCore;
using ExerciseTracker.Model;

namespace ExerciseTracker.BusinessLogic
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server = (localdb)\mssqllocaldb; Database=ExerciseTracker; Trusted_Connection=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<Set> Sets { get; set; }
    }
}
