using RentalPoint.Api.Exceptions;
using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class ItemService : GenericService<Item>, IItemService
    {
        private readonly ICategoryRepository _categoryRepository;

        public ItemService(
            IItemRepository repository,
            ICategoryRepository categoryRepository) : base(repository)
        {
            _categoryRepository = categoryRepository;
        }

        public override async Task CreateAsync(Item model, CancellationToken cancellationToken)
        {
            _ = await _categoryRepository.GetByIdAsync(model.CategoryId, cancellationToken)
                ?? throw new NotFoundException("Category with such id doesnt exist");

            await base.CreateAsync(model, cancellationToken);
        }
    }
}
