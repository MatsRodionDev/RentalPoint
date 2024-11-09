using RentalPoint.Api.Exceptions;
using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class PaymentService : GenericService<Payment>, IPaymentService
    {
        private readonly IRentalRepository _rentalRepository;

        public PaymentService(
            IPaymentRepository repository,
            IRentalRepository rentalRepository) : base(repository)
        {
            _rentalRepository = rentalRepository;   
        }

        public override async Task CreateAsync(Payment model, CancellationToken cancellationToken)
        {
            var rental = await _rentalRepository.GetByIdAsync(model.RentalId, cancellationToken) 
                ?? throw new BadRequestException("Rental with such id doesnt exist");

            if(rental.Payment is not null)
            {
                throw new BadRequestException("This rental has already been paid");
            }

            if(model.Amount < rental.Item!.Price)
            {
                throw new BadRequestException("Not enough money to pay");
            }
            
            await _repository.AddAsync(model, cancellationToken);
        }
    }
}
