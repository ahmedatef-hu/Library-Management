using AutoMapper;
using LibraryManagement_Final.DTOs.Book;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.UnitOFWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LibraryManagement_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class booksController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public booksController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookDTO dto)
        {
            var books = await unitOfWork.bookRepo.GetAll();

            if(books.Any(c => c.ISBN == dto.ISBN))
            {
                return BadRequest("ISBN Already Existed");
            }

            if(dto.Price < 0)
            {
                return BadRequest($"Price Must Be Greater 0");
            }

            var book = mapper.Map<Book>(dto);
            await unitOfWork.bookRepo.Create(book);
            unitOfWork.Save();
            return Created();
        }

        [HttpGet("search")]
        public async Task<IActionResult> search(string keyword)
        {
            var books = await unitOfWork.bookRepo.Search(keyword);
            var dto = mapper.Map<List<BookSearchDto>>(books);
            return Ok(dto);
        }

        [HttpGet("most-expensive")]
        public async Task<IActionResult> MostExpensive()
        {
            var book = await unitOfWork.bookRepo.MostExpensive();
            var bookdto = mapper.Map<GetBookDTO>(book);
            bookdto.CategoryName = book.Title;
            return Ok(bookdto);
        }
    }
}
