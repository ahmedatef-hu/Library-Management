using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
