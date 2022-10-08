using Microsoft.EntityFrameworkCore;

namespace LibraryStore.Data
{
    public class LibraryContext: DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options): base(options) 
        {
            //we have to pass the same settings in the base class constructor, which is DbContext, thats why we use the base keyword

        }
        public DbSet<Books> Books { get; set; }
    }
}
