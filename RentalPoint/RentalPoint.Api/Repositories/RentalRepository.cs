using Microsoft.EntityFrameworkCore;
using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;
using static RentalPoint.Api.Interfaces.Entity.IBaseModel;

namespace RentalPoint.Api.Repositories
{
    public class RentalRepository : GenericRepository<Rental> , IRentalRepository
    {
        public RentalRepository(ApplicationDbContext context) : base(context)
        {

        }

        public override async Task<Rental?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbSet
                .Include(r => r.Item)
                .Include(r => r.Payment)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);
        }

        public override async Task<List<Rental>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbSet
                .Include(r => r.Item)
                .Include(r => r.Payment)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
    }
}
