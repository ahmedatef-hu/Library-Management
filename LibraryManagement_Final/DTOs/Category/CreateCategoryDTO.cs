using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.DTOs.Category
{
    public class CreateCategoryDTO
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
