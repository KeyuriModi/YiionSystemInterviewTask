using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    public interface IHobbyService : IRepository<Hobby>
    {
    }
    public class HobbyService : Repository<Hobby>, IHobbyService
    {
        public HobbyService(StudentsContext studentcontext) : base(studentcontext)
        {
        }
    }
}
