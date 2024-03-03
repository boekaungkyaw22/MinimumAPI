using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace MinimumAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Reading all Shirts";
        }

        [HttpGet("{id}")]
        public string GetShirtsById (int id,[FromQuery] string color)
        {
            return $"Reading Shirts Id:{id} and color: {color}";
        }

        [HttpPost]
        public string CreateShirt ()
        {
            return "Creating Shirts";
        }

        [HttpPut("{id}")]
        public string UpdateShirt (int id)
        {
            return $"Update Shirts Id: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt (int id)
        {
            return $"Deleting Shirt Id: {id}";
        }
    }
}
 