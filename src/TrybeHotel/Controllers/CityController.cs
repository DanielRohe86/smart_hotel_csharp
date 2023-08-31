using Microsoft.AspNetCore.Mvc;
using TrybeHotel.Models;
using TrybeHotel.Repository;

namespace TrybeHotel.Controllers
{
    [ApiController]
    [Route("city")]
    public class CityController : Controller
    {
        private readonly ICityRepository _repository;
        public CityController(ICityRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult GetCities(){
            var allCities = _repository.GetCities();
            return Ok(allCities);
        }
        
        [HttpPost]
        public IActionResult PostCity([FromBody] City city){
            var cityDto = _repository.AddCity(city);
            return Created("", cityDto);
        }
        
        // 3. Desenvolva o endpoint PUT /city
        [HttpPut]
        public IActionResult PutCity([FromBody] City city){
            return Ok(_repository.UpdateCity(city));
        }
    }
}