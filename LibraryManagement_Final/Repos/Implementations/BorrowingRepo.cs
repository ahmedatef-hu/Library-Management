using LibraryManagement_Final.Data;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement_Final.Repos.Implementations
{
    public class BorrowingRepo : GenericRepo<Borrowing>, IBorrowingRepo
    {
        public BorrowingRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<ICollection<Borrowing>> GetAllWithDetails()
        {
            return await context.Borrowings
                .Include(x => x.Book)
                .Include(x => x.Member)
                .ToListAsync();
        }

        public async Task<Borrowing> Return(int id)
        {
            var borrow = await GetById(id);

            if(borrow == null || borrow.ReturnDate != null)
            {
                return null;
            }
            var book = await context.Books.FirstOrDefaultAsync(c => c.Id == borrow.BookId);
            if(book == null)
            {
                return null;
            } 

            borrow.ReturnDate = DateTime.Now;
            book.IsAvailable = true;
            return borrow;
        }
    }
}
