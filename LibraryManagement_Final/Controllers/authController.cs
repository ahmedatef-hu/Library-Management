using LibraryManagement_Final.DTOs.Auth;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.UnitOFWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class authController : ControllerBase
    {
        private readonly IUnitOfWork repo;

        public authController(IUnitOfWork repo)
        {
            this.repo = repo;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO dto)
        {
            var result = await repo.authRepo.Login(dto);

            if (result == null)
                return Unauthorized("email or password not valid");

            return Ok(result);
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterRequestDTO dto)
        {
            if (dto == null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            var regrequest = new User
            {
                Email = dto.Email,
                Name = dto.Name,
                Password = dto.Password,
                Role = "Student"
            };

            if (await repo.authRepo.Register(regrequest) == true)
            {
                return Created();
            }

            return BadRequest("email already exists");

        }
    }
}
