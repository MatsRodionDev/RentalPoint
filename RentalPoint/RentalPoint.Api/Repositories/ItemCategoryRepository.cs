using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class ItemCategoryRepository : GenericRepository<ItemCategory> , IItemCategoryRepository
    {
        public ItemCategoryRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
