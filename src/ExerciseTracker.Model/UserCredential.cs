using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public class UserCredential : ModelObject<int>
    {
        public int UserId { get; set; }
        public string Credential { get; set; }
    }
}
