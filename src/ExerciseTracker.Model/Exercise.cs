using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public class Exercise : ReferenceObject<int>
    {
        public int ExerciseTypeId { get; set; }
        public string ExerciseName { get; set; }
    }
}
