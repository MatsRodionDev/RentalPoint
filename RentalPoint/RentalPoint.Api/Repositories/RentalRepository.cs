using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class RentalRepository : GenericRepository<Rental> , IRentalRepository
    {
        public RentalRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
