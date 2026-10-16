using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.DTOs.Borrowing
{
    public class CreateBorrowingDTO
    {
        [Required]
        public DateTime BorrowDate { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
    }
}
