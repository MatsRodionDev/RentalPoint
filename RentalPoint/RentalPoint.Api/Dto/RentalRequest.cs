namespace RentalPoint.Api.Dto
{
    public record RentalRequest(
         Guid ClientId,
         Guid ItemId,
         DateTime RentalDate,
         DateTime ReturnDate);
}
