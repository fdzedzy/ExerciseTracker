using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public class Set : ModelObject<int>
    {
        public int WorkoutId { get; set; }
        public int ExerciseId { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
    }
}
