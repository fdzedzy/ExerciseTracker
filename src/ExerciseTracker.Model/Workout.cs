using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExerciseTracker.Model
{
    public class Workout : DomainObject<int>
    {
        private DateTime _EndTime => (DateTime) (EndTime ?? DateTime.Now);

        public int UserId { get; set; }
        public DateTime WorkoutDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Collection<Set> Sets { get; set; }

        public TimeSpan WorkoutDuration => StartTime - _EndTime;
    }
}
