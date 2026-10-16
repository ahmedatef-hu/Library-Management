using AutoMapper;
using LibraryManagement_Final.DTOs.Member;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.UnitOFWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LibraryManagement_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class membersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public membersController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateMemberDTO dto)
        {
            var members = await unitOfWork.memberRepo.GetAll();
            if(members.Any(c => c.Email == dto.Email))
            {
                return BadRequest("Member Already Existe");
            }
            var member = mapper.Map<Member>(dto);
            await unitOfWork.memberRepo.Create(member);
            unitOfWork.Save();
            return Created();
        }

        [HttpGet("top-readers")]
        public async Task<IActionResult> GetTopReaders()
        {
            var readers = await unitOfWork.memberRepo.TopReaders();
            var redearsdto = mapper.Map<List<GetMemberDTO>>(readers);
            return Ok(redearsdto);
        }

        [HttpGet("{id}/statistics")]
        public async Task<IActionResult> StatisticsMember(int id)
        {
            var member = await unitOfWork.memberRepo.Statistics(id);
            return Ok(member);
        }

    }
}
