using LibraryManagement_Final.Data;
using LibraryManagement_Final.DTOs.Member;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement_Final.Repos.Implementations
{
    public class MemberRepo : GenericRepo<Models.Member>, IMemberRepo
    {
        public MemberRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<StatisticsDTO> Statistics(int id)
        {
            var member = context.Members
                .Include(c => c.Borrowings)
                .FirstOrDefault(c => c.Id == id);
            var memberStatistic = new StatisticsDTO
            {
                Id = member.Id,
                Name = member.FullName,
                TotalBorrowedBooks = member.Borrowings.Count(),
                ReturnedBooks = member.Borrowings.Where(c => c.ReturnDate != null).Count(),
                CurrentlyBorrowedBooks = member.Borrowings.Where(c => c.ReturnDate == null).Count()
            };
            return memberStatistic;
        }

        public async Task<List<Member>> TopReaders()
        {
            return await context.Members
                .OrderByDescending(c => c.Borrowings.Count())
                .Take(5).ToListAsync();
        }
    }
}
