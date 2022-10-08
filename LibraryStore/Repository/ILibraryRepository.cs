using LibraryStore.Model;

namespace LibraryStore.Repository
{
    public interface ILibraryRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookByIdAsync(int id);
        Task<int> AddBookAsync(BookModel bookModel);
    }
}