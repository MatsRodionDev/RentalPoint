using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class ItemRepository : GenericRepository<Item> , IItemRepository
    {
        public ItemRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
