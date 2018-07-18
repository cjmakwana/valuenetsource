using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurtleAttack.Domain.Entities;
using TurtleAttack.Domain.Services;

namespace TurtleAttack.Controllers
{
    [Produces("application/json")]
    [Route("api/Panel")]
    public class PanelController : Controller
    {
        [HttpGet]
        public IEnumerable<Panel> Get()
        {
            return PanelService.Instance.GetAll();
        }

        [HttpGet("{id}")]
        public Panel Get(string id)
        {
            return PanelService.Instance.Get(id);
        }

        [HttpPost]
        public void Post([FromBody]Panel value)
        {
            PanelService.Instance.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Panel value)
        {
            PanelService.Instance.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            PanelService.Instance.Remove(id);
        }
    }
}