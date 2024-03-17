using Microsoft.AspNetCore.Mvc;
using MinimumAPI.Filter;
using MinimumAPI.Models;
using MinimumAPI.Models.Repository;
using System.ComponentModel;

namespace MinimumAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {



        [HttpGet]
        public List<Shirts> GetShirts()
        {
            return ShirtRepository.GetShirts();
        }

        [HttpGet("{id}")]
        [Shirt_ValidateShirtIdFilter]
        //public string GetShirtsById (int id,[FromHeader(Name = "Color")] string color) Using Header
        public IActionResult GetShirtsById(int id)
        {

            return Ok(ShirtRepository.GetShirtById(id));

        }

        [HttpPost]
        public string CreateShirt([FromBody] Shirts shirts)
        {
            return "Creating Shirts";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Update Shirts Id: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting Shirt Id: {id}";
        }
    }
}
