using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class ReviewService : GenericService<Review>, IReviewService
    {
        public ReviewService(IReviewRepository repository) : base(repository)
        {

        }
    }
}
