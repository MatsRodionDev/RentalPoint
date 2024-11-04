using RentalPoint.Api.Exceptions;
using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class RentalService : GenericService<Rental>, IRentalService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IItemRepository _itemRepository;

        public RentalService(
            IRentalRepository repository,
            IClientRepository clientRepository,
            IItemRepository itemRepository) : base(repository)
        {
            _clientRepository = clientRepository; 
            _itemRepository = itemRepository;
        }

        public async Task RentItemAsync(Rental rental, CancellationToken cancellationToken)
        {
            _ = await _itemRepository.GetByIdAsync(rental.ClientId, cancellationToken) ??
                throw new NotFoundException("Item with such id doesn't exist");

            _ = await _clientRepository.GetByIdAsync(rental.ClientId, cancellationToken) ??
                throw new NotFoundException("User with such id doesn't exist");

            await _repository.AddAsync(rental, cancellationToken);

        }
    }
}
