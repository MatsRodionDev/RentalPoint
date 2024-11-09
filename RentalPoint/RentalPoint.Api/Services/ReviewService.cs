using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class ReviewService : GenericService<Review>, IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository repository) : base(repository)
        {
            _reviewRepository = repository;
        }

        public async Task<List<Review>> GetByItemId(Guid itemId, CancellationToken cancellationToken)
        {
            return await _reviewRepository.GetByItemIdAsync(itemId, cancellationToken);
        }
    }
}
