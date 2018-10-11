using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public class ReferenceObject<TKey> : IReferenceObject<TKey>
    {
        public TKey Id { get; set; }
    }
}
