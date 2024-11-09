namespace RentalPoint.Api.Dto
{
    public record ReviewRequest(
        Guid ItemId,
        Guid ClientId,
        int Rating,
        string Comment);
}
