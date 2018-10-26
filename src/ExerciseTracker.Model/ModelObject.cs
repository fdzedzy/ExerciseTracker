using System;
using System.Collections.Generic;
using System.Text;
using ExerciseTracker.Model.Interface;

namespace ExerciseTracker.Model
{
    public class ModelObject<TKey> : IModelObject<TKey>
    {
        public TKey Id { get; set; }
    }
}
