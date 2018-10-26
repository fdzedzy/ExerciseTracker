using System;
using System.Collections.Generic;
using System.Text;
using ExerciseTracker.Model.Interface;

namespace ExerciseTracker.Model
{
    public abstract class DomainObject<TKey> : IDomainObject<TKey>
    {
        public TKey Id { get; set; }
    }
}
