using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public interface IReferenceObject<TKey>
    {
        TKey Id { get; set; }
    }
}
