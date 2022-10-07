using System;
using System.Collections.Generic;

#nullable disable

namespace Students.Models
{
    public partial class Stud
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int? HobbyId { get; set; }
        public string Address { get; set; }
        public int? BranchId { get; set; }
        public string StudentImage { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Hobby Hobby { get; set; }
    }
}
