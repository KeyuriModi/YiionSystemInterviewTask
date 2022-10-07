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
    public class HobbyController : ControllerBase
    {
        public IHobbyService service { get; set; }
        public HobbyController(IHobbyService hobbyService)
        {
            service = hobbyService;
        }
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok(service.GetData());
        }
    }
}
