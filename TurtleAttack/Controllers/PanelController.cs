using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TurtleAttack.Controllers
{
    [Produces("application/json")]
    [Route("api/Panel")]
    public class PanelController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Panel 1", "Panel 2" };
        }

    }
}