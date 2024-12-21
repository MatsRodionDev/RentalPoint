namespace RentalPoint.Api.Dto
{
    public record RentalResponse(
        Guid Id,
        ItemRequest Item,
        bool ItemIsBacked,
        Guid ClientId);
}
