using RentalPoint.Api.Models;

namespace RentalPoint.Api.Dto
{
    public record ReviewResponse(
        Guid ItemId,
        int Rating,
        string Comment,
        ClientReviewResponse Client);
}
