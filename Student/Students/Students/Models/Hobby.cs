using System;
using System.Collections.Generic;

#nullable disable

namespace Students.Models
{
    public partial class Hobby
    {
        public Hobby()
        {
            Studs = new HashSet<Stud>();
        }

        public int HobbyId { get; set; }
        public string HobbyName { get; set; }

        public virtual ICollection<Stud> Studs { get; set; }
    }
}
