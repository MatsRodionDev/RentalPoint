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
            
            var item = await _itemRepository.GetByIdAsync(rental.ClientId, cancellationToken) ??
                throw new NotFoundException("Item with such id doesn't exist");

            _ = await _clientRepository.GetByIdAsync(rental.ClientId, cancellationToken) ??
                throw new NotFoundException("User with such id doesn't exist");

            if(item.IsRented)
            {
                throw new BadRequestException("Item is already rented");
            }

            await _repository.AddAsync(rental, cancellationToken);

        }

        public async Task BackItemAsync(Guid rentalId, CancellationToken cancellationToken)
        {
            var rental = await _repository.GetByIdAsync(rentalId, cancellationToken) ??
                throw new NotFoundException("Rental with such id doesnt exist");

            if(rental.ItemIsBacked)
            {
                throw new BadRequestException("Item has already backed");
            }

            var item = await _itemRepository.GetByIdAsync(rental.ItemId, cancellationToken);
            item!.IsRented = false;

            rental.ItemIsBacked = true;

            await _repository.UpdateAsync(rental, cancellationToken);
            await _itemRepository.UpdateAsync(item, cancellationToken);
        }
    }
}
