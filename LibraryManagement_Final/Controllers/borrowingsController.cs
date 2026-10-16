using AutoMapper;
using LibraryManagement_Final.DTOs.Borrowing;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.UnitOFWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LibraryManagement_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class borrowingsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public borrowingsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBorrowingDTO dto)
        {
            var borrow = new Borrowing
            {
                BookId = dto.BookId,
                BorrowDate = dto.BorrowDate,
                MemberId = dto.MemberId,
            };
            var book = await unitOfWork.bookRepo.GetById(dto.BookId);
            if(book.IsAvailable == false)
            {
                return BadRequest("The Book Not Available");
            }
            book.IsAvailable = false;
            await unitOfWork.borrowingRepo.Create(borrow);
            unitOfWork.Save();
            return Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var borrowings = await unitOfWork.borrowingRepo.GetAllWithDetails();
            var res = borrowings.Select(x => new
            {
                Id = x.Id,
                BorrowDate = x.BorrowDate,
                ReturnDate = x.ReturnDate,
                BookId = x.BookId,
                BookTitle = x.Book.Title,
                BookPrice = x.Book.Price,
                BookISBN = x.Book.ISBN,
                MemberId = x.MemberId,
                MemberName = x.Member.FullName,
                MemberEmail = x.Member.Email,
                MemberPhone = x.Member.Phone
            }).ToList();
            return Ok(res);
        }
        [HttpPut("{id}/return")]
        public async Task<IActionResult> Return(int id)
        {
            var borrow = await unitOfWork.borrowingRepo.Return(id);

            if (borrow == null)
                return BadRequest("Borrowing not found or book already returned");

            unitOfWork.Save();

            return Ok();
        }
    }
}
