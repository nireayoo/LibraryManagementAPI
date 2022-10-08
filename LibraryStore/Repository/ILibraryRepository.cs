using LibraryStore.Model;

namespace LibraryStore.Repository
{
    public interface ILibraryRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
    }
}