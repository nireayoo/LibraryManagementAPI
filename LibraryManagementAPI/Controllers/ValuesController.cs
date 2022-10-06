using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("get-all")]
        public string GetAll()
        {
            return "hello from get all";
        }
        [HttpGet("get-all1")]
        public string GetAll1()
        {
            return "hello from get all 1";
        }

    }
}
