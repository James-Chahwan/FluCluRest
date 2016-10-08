using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using FluCluRest.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FluCluRest.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/Symptom")]
    public class SymptomsController : Controller
    {
        public SymptomsController(ISymptomsRepo symptomItems)
        {
            SympItems = symptomItems;
        }
        public ISymptomsRepo SympItems { get; set; }

        [HttpGet]
        public IEnumerable<Symptom> GetAll()
        {
            return SympItems.getAll();
        }
    }
}
