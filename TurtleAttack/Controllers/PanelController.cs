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
            var list = new List<string>();
            for(int i = 0; i < 10; ++i)
            {
                list.Add(Guid.NewGuid().ToString("N"));
            }
            return list;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }
    }
}