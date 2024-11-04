using RentalPoint.Api.Models;

namespace RentalPoint.Api.Interfaces.Services
{
    public interface IRentalService : IGenericService<Rental>
    {
        Task RentItemAsync(Rental rental, CancellationToken cancellationToken);
    }
}
