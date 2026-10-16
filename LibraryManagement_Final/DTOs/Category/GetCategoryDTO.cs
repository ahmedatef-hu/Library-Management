using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.DTOs.Category
{
    public class GetCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
