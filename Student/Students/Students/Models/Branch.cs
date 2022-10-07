using System;
using System.Collections.Generic;

#nullable disable

namespace Students.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Studs = new HashSet<Stud>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; }

        public virtual ICollection<Stud> Studs { get; set; }
    }
}
