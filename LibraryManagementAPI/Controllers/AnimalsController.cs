using LibraryManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private static List<AnimalModel> animals = null;
        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel(){ Id= 1, Name = "big"},
                new AnimalModel(){ Id= 2, Name = "small"}
            };
        }
        [HttpGet]
        [Route(" ", Name = "All")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [HttpGet]
        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            return AcceptedAtRoute("all");
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id==0)
            {
                return BadRequest();
            }
            return Ok(animals.FirstOrDefault(x => x.Id == id));
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("abc"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }
        [HttpPost("")]
       
        public IActionResult AddAnimals(AnimalModel animal) //we want to add some data
        {
            animals.Add(animal);
            return CreatedAtAction("~/api/animals", new { id = animal.Id}); //url of the newly created record
            
        }
    }
}
