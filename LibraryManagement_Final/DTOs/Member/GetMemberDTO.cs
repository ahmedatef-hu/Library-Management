using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_Final.DTOs.Member
{
    public class GetMemberDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
