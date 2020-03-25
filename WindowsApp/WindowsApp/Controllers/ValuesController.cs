using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WindowsApp.Controllers
{
    [Route("api/[controller]")]    
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Json(new string[] { "value1", "value2" });
        }
    }
}
