using LibraryManagement_Final.DTOs.Auth;
using LibraryManagement_Final.Models;

namespace LibraryManagement_Final.JWT
{
    public interface IAuthRepo
    {
        public Task<string> Login(LoginRequestDTO dto);
        public Task<bool> Register(User user);
    }
}
