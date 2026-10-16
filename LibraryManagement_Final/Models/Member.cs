using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Member
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }

        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
    }
}
