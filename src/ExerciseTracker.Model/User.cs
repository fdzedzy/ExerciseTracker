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

        public double Age()
        {
            int days = (DateTime.Today - BirthDate).Days;
            double years = days / 365;
            return years;
        }
    }
}
