using Microsoft.EntityFrameworkCore;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    public interface IStudService : IRepository<Stud>
    {
        IEnumerable<Stud> GetAllData();
    }
    public class StudService : Repository<Stud> , IStudService
    {
        public StudService(StudentsContext context) : base(context)
        {

        }

        public IEnumerable<Stud> GetAllData()
        {
           return context.Set<Stud>().Include(x => x.Hobby).Include(y => y.Branch).ToList();
        }
    }
}
