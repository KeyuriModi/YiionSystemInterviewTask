using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudController : ControllerBase
    {
        public IStudService service { get; set; }
        public StudController(IStudService studservice)
        {
            service = studservice;
        }
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok(service.GetAllData());
        }
        [HttpGet("{id}")]
        public IActionResult GetDataByID(int id)
        {
            return Ok(service.GetDataByID(id));
        }
        [HttpPost]
        public IActionResult AddData([FromBody]Stud student)
        {
            return Ok(service.AddData(student));
        }
        [HttpPut("{id}")]
        public IActionResult UpdateData(int id,[FromBody]Stud student)
        {
            var uid = service.GetDataByID(id);
            return Ok(service.UpdateData(uid, student));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            return Ok(service.DeleteData(id));
        }
    }
}
