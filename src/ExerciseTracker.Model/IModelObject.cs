using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public interface IModelObject<TKey>
    {
        TKey Id { get; set; }
    }
}
