using LibraryManagement_Final.Data;
using LibraryManagement_Final.JWT;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.Repos.Interfaces;

namespace LibraryManagement_Final.UnitOFWork
{
    public class UnitOfWOrk : IUnitOfWork
    {
        private readonly AppDbContext context;

        public IMemberRepo memberRepo { get; }
        public IBookRepo bookRepo { get; }
        public IBorrowingRepo borrowingRepo { get; }
        public IAuthRepo authRepo { get; }
        public IGenericRepo<Category> categoryRepo { get; }

        public UnitOfWOrk(AppDbContext context, IBookRepo bookRepo, IGenericRepo<Category> categoryRepo, IMemberRepo memberRepo, IBorrowingRepo borrowingRepo, IAuthRepo authRepo)
        {
            this.context = context;
            this.bookRepo = bookRepo;
            this.categoryRepo = categoryRepo;
            this.memberRepo = memberRepo;
            this.borrowingRepo = borrowingRepo;
            this.authRepo = authRepo;
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
