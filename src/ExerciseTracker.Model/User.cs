using System;

namespace ExerciseTracker.Model
{
    public class User : ModelObject<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int HeightInInches { get; set; }
        public double WeightInPounds { get; set; }
        public UserCredential UserCredential { get; set; }

        public double Bmi => Math.Round((WeightInPounds / (HeightInInches * HeightInInches)) * 703, 1);

        public double Age => (DateTime.Today - BirthDate).Days / 365;
    }
}
