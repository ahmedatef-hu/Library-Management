using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.DTOs.Member
{
    public class CreateMemberDTO
    {
        [Required]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
    }
}
