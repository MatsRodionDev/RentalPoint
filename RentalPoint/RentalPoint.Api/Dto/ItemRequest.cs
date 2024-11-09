using RentalPoint.Api.Models;

namespace RentalPoint.Api.Dto
{
    public record ItemRequest(
        string Name,
        string Description,
        decimal Price);
}
