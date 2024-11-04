using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
