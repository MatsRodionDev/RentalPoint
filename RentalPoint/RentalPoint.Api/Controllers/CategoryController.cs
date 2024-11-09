using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentalPoint.Api.Dto;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(
            ICategoryService categoryService,
            IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var categories = await _categoryService.GetAllAsync(cancellationToken);

            var categoriesResponse = _mapper.Map<List<CategoryResponse>>(categories);

            return Ok(categoriesResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryRequest dto, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(dto);

            await _categoryService.CreateAsync(category, cancellationToken);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] CategoryRequest dto, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(dto);

            await _categoryService.UpdateAsync(id, category, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Update(Guid id, CancellationToken cancellationToken)
        {
            await _categoryService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}
