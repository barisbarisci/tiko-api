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
    public class HouseController : ControllerBase
    {
        private IHouseRepo _houseRepo;

        public HouseController(IHouseRepo houseRepo)
        {
            _houseRepo = houseRepo;
        }

        [HttpGet]
        public List<House> Get()
        {
            return _houseRepo.List();
        }

        [HttpGet("filter")]
        public List<House> GetFilter(int? cityId, int? agentId)
        {
            return _houseRepo.FilterList(cityId, agentId);
        }
        [HttpGet("{id}")]
        public House Get(int id)
        {
            return _houseRepo.Find(id);
        }

        [HttpPost]
        public House Add(House house)
        {
            return _houseRepo.Add(house);
        }

        [HttpPut]
        public void Update(House house)
        {
            _houseRepo.Update(house);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _houseRepo.Delete(id);
        }
    }
}
