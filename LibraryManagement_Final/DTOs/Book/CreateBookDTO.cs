using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.DTOs.Book
{
    public class CreateBookDTO
    {
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

        public int CategoryId { get; set; }
    }
}
