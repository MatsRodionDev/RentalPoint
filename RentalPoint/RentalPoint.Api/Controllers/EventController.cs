using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentalPoint.Api.Dto;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;

        public EventController(
            IEventService eventService,
            IMapper mapper)
        {
            _eventService = eventService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var categories = await _eventService.GetAllAsync(cancellationToken);

            var categoriesResponse = _mapper.Map<List<EventResponse>>(categories);

            return Ok(categoriesResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EventRequest dto, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Event>(dto);

            await _eventService.CreateAsync(category, cancellationToken);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] EventRequest dto, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Event>(dto);

            await _eventService.UpdateAsync(id, category, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await _eventService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}
