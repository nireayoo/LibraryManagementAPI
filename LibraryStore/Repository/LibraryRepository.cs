using LibraryStore.Data;
using LibraryStore.Model;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.EntityFrameworkCore;

namespace LibraryStore.Repository
{
    public class LibraryRepository:ILibraryRepository
    {
        private readonly LibraryContext _context;

        //creating this public method to return all the books in te database(R in CRUD)
        //we need the dbcontext instance to get our data so instead of calling it everytime we can get to use dependency injection
        public LibraryRepository(LibraryContext context) //instance of dbcontext
        {
            _context = context;
        }
        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            //var records = _context.Books.ToListAsync();
            //WE want to convert the book to bookmodel so we use the select method with lambda expression
            var records = await _context.Books.Select( x => new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
            }).ToListAsync();

            return records;
            //we can use an automapper instead of having to convert tables manually
        }
        //to get just one book
        public async Task<List<BookModel>> GetBookByIdAsync(int id) //we need sth unique so we use id
        {
   
            //we can use the find method with the primary key only and not another column, else we use thw where clause
            var records = await _context.Books.Select(x => new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
            }).ToListAsync();

            return records;
            //we can use an automapper instead of having to convert tables manually
        }
    }
}
