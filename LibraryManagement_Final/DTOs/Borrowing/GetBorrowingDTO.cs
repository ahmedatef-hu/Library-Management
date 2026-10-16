using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.DTOs.Borrowing
{
    public class GetBorrowingDTO
    {
        public int Id { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
    }
}
