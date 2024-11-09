using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentalPoint.Api.Dto;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;

        public ItemController(
            IItemService itemService,
            IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await _itemService.GetByIdAsync(id, cancellationToken);

            var itemResponse = _mapper.Map<ItemResponse>(item);

            return Ok(itemResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var items = await _itemService.GetAllAsync(cancellationToken);

            var itemsResponse = _mapper.Map<List<ItemResponse>>(items);

            return Ok(itemsResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ItemRequest dto, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<Item>(dto);

            await _itemService.CreateAsync(item, cancellationToken);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ItemRequest dto, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<Item>(dto);

            await _itemService.UpdateAsync(id, item, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Update(Guid id,  CancellationToken cancellationToken)
        {
            await _itemService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}
