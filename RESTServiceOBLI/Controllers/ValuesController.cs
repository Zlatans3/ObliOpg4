using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NFL2021;
using NFL2021.Model;
using RESTServiceOBLI.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestItemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PbpController : ControllerBase
    {

        private readonly ManageFbPlayers _mgr = new ManageFbPlayers();

        // GET: api/<PBPController>
        [HttpGet]
        public IEnumerable<FootBallPlayer> Get()
        {
            return _mgr.Get();
        }

        // GET api/<PBPController>/5
        [HttpGet("{id}")]
        public FootBallPlayer Get(int id)
        {
            return _mgr.Get(id);
        }
        // POST api/<PBPController>
        [HttpPost]
        bool Post([FromBody] FootBallPlayer value)
        {
            _mgr.Create(value);
            return true;
        }

        // PUT api/<PBPController>/5
        [HttpPut("{id}")]
        bool Put(int id, [FromBody] FootBallPlayer value)
        {
            _mgr.Update(id, value);
            return true;
        }

        // DELETE api/<PBPController>/5
        [HttpDelete("{id}")]
        FootBallPlayer Delete(int id)
        {
            FootBallPlayer footBallPlayer = _mgr.Get(id);
            _mgr.Delete(id);
            return footBallPlayer;

        }
    }
}