using LibraryManagement_Final.Models;

namespace LibraryManagement_Final.Repos.Interfaces
{
    public interface IBookRepo : IGenericRepo<Book>
    {
        Task<ICollection<Book>> Search(string Keyword);
        Task<Book> MostExpensive();
    }
}
