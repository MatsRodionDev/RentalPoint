using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class ItemService : GenericService<Item>, IItemService
    {
        public ItemService(IItemRepository repository) : base(repository)
        {

        }
    }
}
