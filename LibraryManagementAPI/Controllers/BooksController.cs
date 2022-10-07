using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")] //this is the base route
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("id2")]
        public string GetById(int id)
        {
            return "hello int" + id;
        }
        [HttpGet("{id}")]
        public string GetByIdString(string id)
        {
            return "hello string " + id;
        }
        [HttpGet]
        public string GetByIdRegex(string id)
        {
            return "hello regex " + id;
        }

    }
}
