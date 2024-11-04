using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class DiscountRepository : GenericRepository<Discount> , IDiscountRepository
    {
        public DiscountRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
