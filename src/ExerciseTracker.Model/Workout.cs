using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public class Workout : ModelObject<int>
    {
        public int UserId { get; set; }
        public DateTime WorkoutDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
