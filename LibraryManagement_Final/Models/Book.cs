using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.Models
{
    [Index(nameof(ISBN), IsUnique = true)]
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required, Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        public bool IsAvailable = true;

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();


    }
}
