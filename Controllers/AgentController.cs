using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TikoAPI.Models;
using TikoAPI.Repository.IRepos;

namespace TikoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgentController : ControllerBase
    {
        private IAgentRepo _agentRepo;

        public AgentController(IAgentRepo agentRepo)
        {
            _agentRepo = agentRepo;
        }

        [HttpGet]
        public List<Agent> Get()
        {
            return _agentRepo.List();
        }
        [HttpGet("{id}")]
        public Agent Get(int id)
        {
            return _agentRepo.Find(id);
        }

        [HttpPost]
        public Agent Add(Agent house)
        {
            return _agentRepo.Add(house);
        }

        [HttpPut]
        public void Update(Agent house)
        {
            _agentRepo.Update(house);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _agentRepo.Delete(id);
        }
    }
}
