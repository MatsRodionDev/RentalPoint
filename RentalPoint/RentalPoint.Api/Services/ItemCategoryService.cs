using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class ItemCategoryService : GenericService<ItemCategory>,  IItemCategoryService
    {
        public ItemCategoryService(IItemCategoryRepository repository) : base(repository)
        {
            
        }
    }
}
