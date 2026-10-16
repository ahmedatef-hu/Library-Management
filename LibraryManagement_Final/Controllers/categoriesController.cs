using AutoMapper;
using LibraryManagement_Final.DTOs.Category;
using LibraryManagement_Final.Models;
using LibraryManagement_Final.UnitOFWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LibraryManagement_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class categoriesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public categoriesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDTO dto)
        {
            var categories = await unitOfWork.categoryRepo.GetAll();
            if(categories.Any(c => c.Name == dto.Name))
            {
                return BadRequest("Category have been Exist");
            }
            var category = mapper.Map<Category>(dto);
            await unitOfWork.categoryRepo.Create(category);
            unitOfWork.Save();
            return Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await unitOfWork.categoryRepo.GetAll();
            var res = mapper.Map<List<GetCategoryDTO>>(categories);
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await unitOfWork.categoryRepo.GetById(id);
            await unitOfWork.categoryRepo.Delete(category);
            unitOfWork.Save();
            return NoContent();
        }
    }
}
