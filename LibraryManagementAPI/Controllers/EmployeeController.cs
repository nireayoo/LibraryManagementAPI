using LibraryManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>(){
                new EmployeeModel{Id = 1, Name = "Babara Page" },
                new EmployeeModel{Id = 2, Name = "Tom Jones" },
                };
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            if (id == 0)
            {
                return NotFound();

            }
            return Ok(new List<EmployeeModel>(){
                new EmployeeModel{Id = 1, Name = "Babara Page" },
                new EmployeeModel{Id = 2, Name = "Tom Jones" },
                });

        }
        [HttpGet("{id}/basic")]
        //to return multiple types of data we need to use action result
        public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();

            }
            return  new EmployeeModel{Id = 1, Name = "Babara Page" };

        }
    }
}
