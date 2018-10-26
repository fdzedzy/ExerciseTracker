using System;
using System.Collections.Generic;
using System.Text;
using ExerciseTracker.Model.ReferenceData;

namespace ExerciseTracker.Model
{
    public class Exercise : ReferenceObject<int>
    {
        public ExerciseTypeEnum ExerciseType { get; set; }
        public string ExerciseDescription { get; set; }
    }
}
