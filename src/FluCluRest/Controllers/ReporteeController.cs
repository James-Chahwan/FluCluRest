using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FluCluRest.Models;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FluCluRest.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/Reportee")]
    public class ReporteeController : Controller
    {
        public ReporteeController(IReporteeRepo reporteeItems)
        {
            RepItems = reporteeItems;
        }
        public IReporteeRepo RepItems { get; set; }

        
        [HttpGet]
        public IEnumerable<Reportee> GetAll()
        {
            return RepItems.getAll();
        }

        [HttpGet("{id}", Name = "GetReportee")]
        public IActionResult GetById(string id)
        {
            var item = RepItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPost(Name ="Create",Order =1)]
        public IActionResult Create([FromBody] Reportee item)
        {
            if (item ==null)
            {
                return BadRequest();
            }
            RepItems.Add(item);
            return CreatedAtRoute("GetReportee", new { id = item.Key }, item);
        }

    }
    


    
}
