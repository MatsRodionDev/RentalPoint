using RentalPoint.Api.Models;

namespace RentalPoint.Api.Interfaces.Services
{
    public interface IReviewService : IGenericService<Review>
    {
        Task<List<Review>> GetByItemId(Guid itemId, CancellationToken cancellationToken);
    }
}
