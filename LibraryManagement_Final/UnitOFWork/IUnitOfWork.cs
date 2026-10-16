using LibraryManagement_Final.JWT;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.Repos.Interfaces;

namespace LibraryManagement_Final.UnitOFWork
{
    public interface IUnitOfWork
    {
        IBookRepo bookRepo { get; }
        IMemberRepo memberRepo { get; }
        IBorrowingRepo borrowingRepo { get; }
        IAuthRepo authRepo { get; }
        IGenericRepo<Category> categoryRepo { get; }
        int Save();
    }
}
