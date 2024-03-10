using Microsoft.AspNetCore.Mvc;
using MinimumAPI.Models;
using System.ComponentModel;

namespace MinimumAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        private List<Shirts> shirts = new List<Shirts>()
        {
            new Shirts { ShirtId = 1, Brand = "My Brand", Color = "Blue", Gender = "Men", Price = 30, Size = 10 },
            new Shirts { ShirtId = 2 , Brand = "My Brand", Color = "Black", Gender = "Men", Price = 35, Size = 12},
            new Shirts { ShirtId = 3 , Brand = "Your Brand", Color = "Green", Gender = "Women", Price = 45, Size = 8 },
            new Shirts { ShirtId = 4, Brand = "Your Brand", Color = "Yelloe" , Gender = "Women", Price = 45, Size = 9}
        };


        [HttpGet]
        public string GetShirts()
        {
            return "Reading all Shirts";
        }

        [HttpGet("{id}")]
        //public string GetShirtsById (int id,[FromHeader(Name = "Color")] string color) Using Header
        public string GetShirtsById (int id,[FromHeader(Name = "Color")] string color)
        {
            return $"Reading Shirts Id:{id} and color: {color}";
        }

        [HttpPost]
        public string CreateShirt ([FromBody] Shirts shirts)
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
 