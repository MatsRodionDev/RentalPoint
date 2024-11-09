namespace RentalPoint.Api.Dto
{
    public record ItemResponse(
        Guid Id,
        string Name,
        string Description,
        decimal Price);
}
