using RentalPoint.Api.Models;

namespace RentalPoint.Api.Interfaces.Repositories
{
    public interface IReviewRepository : IGenericRepository<Review>
    {
        Task<List<Review>> GetByItemIdAsync(Guid itemId, CancellationToken cancellationToken);
    }
}
