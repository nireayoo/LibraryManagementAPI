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
        public async Task<BookModel> GetBookByIdAsync(int bookId) //we need sth unique so we use id
        {
            //we can use the find method with the primary key only and not another column, else we use thw where clause
            var records = await _context.Books.Where(x => x.Id == bookId).Select(x => new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
            }).FirstOrDefaultAsync(); //first or default is better so as not to get an error if the book is not available
            return records;
            //we can use an automapper instead of having to convert tables manually
        }

        public async Task<int> AddBookAsync(BookModel bookModel) //we have to pass an object of the book model cos that is what we are adding
        {
            //we have to convert the data from bookmodel to the book cos thats what the program understands
            var book = new Books()
            {
                //id will be generated and assigned to the book object automatically
                //the new object will be assigned to this template
                Title = bookModel.Title,
                Description= bookModel.Description,

            };
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book.Id;
        }

        public async Task<BookModel> UpdateBooksAsync(int bookId, BookModel bookModel)
        {  
            //to update a resource, we need the id and record we want to update
            //there are two ways to update in ef core. First is to fetch the data

            return records;
           
        }
    }
}
