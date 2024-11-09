using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentalPoint.Api.Dto;
using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        private readonly IMapper _mapper;

        public ReviewController(
            IReviewService reviewService,
            IMapper mapper)
        {
            _reviewService = reviewService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var review = await _reviewService.GetByIdAsync(id, cancellationToken);

            var reviewResponse = _mapper.Map<ReviewResponse>(review);

            return Ok(reviewResponse);
        }

        [HttpGet("item/{id}")]
        public async Task<IActionResult> GetByItemId(Guid id, CancellationToken cancellationToken)
        {
            var reviews = await _reviewService.GetByItemId(id, cancellationToken);

            var reviewsResponse = _mapper.Map<List<ReviewResponse>>(reviews);

            return Ok(reviewsResponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ReviewRequest dto, CancellationToken cancellationToken)
        {
            var review = _mapper.Map<Review>(dto);

            await _reviewService.CreateAsync(review, cancellationToken);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ReviewRequest dto, CancellationToken cancellationToken)
        {
            var review = _mapper.Map<Review>(dto);

            await _reviewService.UpdateAsync(id, review, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await _reviewService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}
