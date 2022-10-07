using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        [HttpGet]
        [Route("[action]")]
        
        public string GetAll()
        {
            return "hello from get all";
        }
        [HttpGet("get-all1")]
        public string GetAll1()
        {
            return "hello from get all 1";
        }
        [HttpGet("books/{id}")]
        public string GetById(int id)
        {
            return "hello " + id;
        }
        [HttpGet("books/{id}/author/{authorid}")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "hello author address" + id + " "+ authorId;
        }
        [HttpGet("search")]
        public string SearchBooks(int id, int authorId,string name,int price)
        {
            return "hello author address" + id + " " + authorId;
        }

    }
}
