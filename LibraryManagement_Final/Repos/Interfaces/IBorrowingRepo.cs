using LibraryManagement_Final.Models;

namespace LibraryManagement_Final.Repos.Interfaces
{
    public interface IBorrowingRepo : IGenericRepo<Borrowing>
    {
        Task<ICollection<Borrowing>> GetAllWithDetails();
        Task<Borrowing> Return(int id);
    }
}
