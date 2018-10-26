using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model.Interface
{
    public interface IDomainObject<TKey>
    {
        TKey Id { get; set; }
    }
}
