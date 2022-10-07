using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    public interface IBranchService : IRepository<Branch>
    {
    }
    public class BranchService : Repository<Branch>, IBranchService
    {
        public BranchService(StudentsContext studentcontext) : base(studentcontext)
        {
        }
    }
}
