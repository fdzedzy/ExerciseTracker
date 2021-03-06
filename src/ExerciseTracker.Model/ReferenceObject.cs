﻿using System;
using System.Collections.Generic;
using System.Text;
using ExerciseTracker.Model.Interface;

namespace ExerciseTracker.Model
{
    public class ReferenceObject<TKey> : IReferenceObject<TKey>
    {
        public TKey Id { get; set; }

        public string Name { get; set; }
    }
}
