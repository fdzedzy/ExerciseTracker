using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseTracker.Model
{
    public class UserCredential : ModelObject<int>
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Credential { get; set; }
        public User User { get; set; }
    }
}
