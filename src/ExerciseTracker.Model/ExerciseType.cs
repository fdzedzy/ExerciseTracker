using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public class ExerciseType : ReferenceObject<int>
    {
        public string ExerciseTypeDescription { get; set; }
    }
}