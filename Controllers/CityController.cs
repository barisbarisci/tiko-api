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
    public class CityController : ControllerBase
    {
        private ICityRepo _cityRepo;

        public CityController(ICityRepo cityRepo)
        {
            _cityRepo = cityRepo;
        }

        [HttpGet]
        public List<City> Get()
        {
            return _cityRepo.List();
        }
        [HttpGet("{id}")]
        public City Get(int id)
        {
            return _cityRepo.Find(id);
        }

        [HttpPost]
        public City Add(City city)
        {
            return _cityRepo.Add(city);
        }

        [HttpPut]
        public void Update(City city)
        {
            _cityRepo.Update(city);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _cityRepo.Delete(id);
        }
    }
}
