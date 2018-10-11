using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public class ModelObject<TKey> : IModelObject<TKey>
    {
        public TKey Id { get; set; }
    }
}
