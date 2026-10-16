using LibraryManagement_Final.Data;
using LibraryManagement_Final.DTOs.Auth;
using LibraryManagement_Final.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LibraryManagement_Final.JWT
{
    public class AuthRepo : IAuthRepo
    {
        private readonly AppDbContext context;
        private readonly IConfiguration config;

        public AuthRepo(AppDbContext context, IConfiguration config)
        {
            this.context = context;
            this.config = config;
        }
        public async Task<string?> Login(LoginRequestDTO dto)
        {
            var existingUser = await context.Users
                .FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (existingUser == null)
                return null;

            if (existingUser.Password == dto.Password)
                return GenerateToken(existingUser.Email);

            return null;
        }

        public async Task<bool> Register(User user)
        {
            var existEmail = await context.Users.AnyAsync(a => a.Email == user.Email);

            if (existEmail)
                return false;

            context.Users.Add(user);
            await context.SaveChangesAsync();

            return true;
        }

        private string GenerateToken(string email)
        {
            #region user_claims

            List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, email),
            new Claim(ClaimTypes.Name, email),
            new Claim("mobile", "01234567890"),

        };

            #endregion

            #region Key
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(config["JWT:Key"]));

            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            #endregion

            var tokenObj = new JwtSecurityToken(
                    issuer: config["JWT:Issuer"],
                    audience: config["JWT:Audience"],
                    claims: claims,
                    signingCredentials: signingCredentials,
                    expires: DateTime.UtcNow.AddHours(Convert.ToDouble(config["JWT:ExpirationInHours"]))
                );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenObj);
            return token;
        }
    }
}
