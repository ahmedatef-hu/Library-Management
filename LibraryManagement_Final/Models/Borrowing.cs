using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.Models
{
    public class Borrowing
    {
        public int Id { get; set; }
        [Required]
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Member Member { get; set; }
        public int MemberId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
