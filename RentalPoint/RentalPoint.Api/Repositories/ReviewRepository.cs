using Microsoft.EntityFrameworkCore;
using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Review>> GetByItemIdAsync(Guid itemId, CancellationToken cancellationToken)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(r => r.Client)
                .Where(r => r.ItemId == itemId)
                .ToListAsync(cancellationToken);
        }
    }
}
