using LibraryStore.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryRepository _libraryRepository;

        //we are getting our data from the repository so we have to inject it in the constructor
        public LibraryController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        [HttpGet] //creating a new action method that can handle the http request
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _libraryRepository.GetAllBooksAsync();
            return Ok(books);   
        }
        ]

    }
}
