using LibraryManagement_Final.Data;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement_Final.Repos.Implementations
{
    public class BookRepo : GenericRepo<Book>, IBookRepo
    {
        public BookRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<Book> MostExpensive()
        {
            var book = context.Books.OrderByDescending(c => c.Price);
            return await book.FirstOrDefaultAsync();
        }

        public async Task<ICollection<Book>> Search(string Keyword)
        {
            return await context.Books.Where(c => c.Author.ToLower().Contains(Keyword.ToLower()) ||
                c.Title.ToLower().Contains(Keyword.ToLower()))
                .OrderBy(c => c.Title)
                .ToListAsync();
        }
    }
}
