using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentalPoint.Api.Dto;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _rentalService;
        private readonly IMapper _mapper;

        public RentalController(
            IRentalService rentalService,
            IMapper mapper)
        {
            _rentalService = rentalService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var rental = await _rentalService.GetByIdAsync(id, cancellationToken);

            var rentalResponse = _mapper.Map<RentalResponse>(rental);

            return Ok(rentalResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var rentals = await _rentalService.GetAllAsync(cancellationToken);

            var rentalsResponse = _mapper.Map<List<RentalResponse>>(rentals);

            return Ok(rentalsResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RentalRequest dto, CancellationToken cancellationToken)
        {
            var rental = _mapper.Map<Rental>(dto);

            await _rentalService.CreateAsync(rental, cancellationToken);

            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await _rentalService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }

        [HttpPatch("back/{rentalId}")]
        public async Task<IActionResult> BackItem(Guid rentalId, CancellationToken cancellationToken)
        {
            await _rentalService.BackItemAsync(rentalId, cancellationToken);

            return NoContent();
        }
    }
}
