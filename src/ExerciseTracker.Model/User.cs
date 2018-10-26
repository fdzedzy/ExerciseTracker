using System;
using System.Collections.ObjectModel;

namespace ExerciseTracker.Model
{
    public class User : ModelObject<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; } //Todo Change this to date only without time
        public int HeightInInches { get; set; }
        public double WeightInPounds { get; set; }
        public UserCredential UserCredential { get; set; }
        public Collection<Workout> Workouts { get; set; }

        public double Bmi => Math.Round((WeightInPounds / (HeightInInches * HeightInInches)) * 703, 1);

        public TimeSpan Age => new TimeSpan(((DateTime.Today - BirthDate).Days / 365));
    }
}
