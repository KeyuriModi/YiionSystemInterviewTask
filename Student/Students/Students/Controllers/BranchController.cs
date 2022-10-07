using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        public IBranchService service { get; set; }
        public BranchController(IBranchService branchService)
        {
            service = branchService;
        }
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok(service.GetData());
        }
    }
}
